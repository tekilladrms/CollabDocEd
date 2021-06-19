using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using CollabDocEd.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.AmazonS3
{
    public class AmazonS3Service
    {
        private string _accessKey = "AKIAZ2ONQXVXURWIYDVK";
        private string _secretKey = "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";
        private string _bucketName = "vitestbucket080621";
        public async IAsyncEnumerable<string> GetListOfDocumentsAsync(string folderName)
        {
            using (var client = new AmazonS3Client(_accessKey, _secretKey, RegionEndpoint.USEast1))
            {
                var request = new ListObjectsV2Request()
                {
                    BucketName = _bucketName,
                    Prefix = $"{_bucketName}/{folderName}/"
                    
                };
                var listObjects = await client.ListObjectsV2Async(request).ConfigureAwait(false);
                
                foreach (var el in listObjects.S3Objects)
                {
                    yield return el.Key;
                }
            }
            
            
        }

        /// <summary>
        /// Upload file to the bucket
        /// </summary>
        /// <param name="file"></param>
        /// <param name="folderName"></param>
        /// <returns>
        /// VersionId
        /// </returns>
        public async Task<string> UploadDocumentToBucket(IFormFile file, string folderName)
        {
            string result;
            using (var client = new AmazonS3Client(_accessKey, _secretKey, RegionEndpoint.USEast1))
            {

                var request = new PutObjectRequest()
                {
                    CannedACL = S3CannedACL.PublicRead,
                    BucketName = _bucketName,
                    Key = $"{folderName}/{file.FileName}",
                    InputStream = file.OpenReadStream(),
                    ContentType = file.ContentType
                };

                var response = await client.PutObjectAsync(request);
                result = response.VersionId;
            }

            return result;

        }

        /// <summary>
        /// Download file from the bucket
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="fileName"></param>
        /// <param name="version"></param>
        /// <returns>
        /// FileStreamResult
        /// </returns>
        public async Task<FileStreamResult> DownloadDocumentFromBucket(string projectName, string fileName, string version)
        {
            using var client = new AmazonS3Client(_accessKey, _secretKey, RegionEndpoint.USEast1);
            var transferUtility = new TransferUtility(client);
            var response = await client.GetObjectAsync(_bucketName, $"{projectName}/{fileName}", version);
            using Stream responseStream = response.ResponseStream;
            var stream = new MemoryStream();
            await responseStream.CopyToAsync(stream);
            stream.Position = 0;
            
            return new FileStreamResult(stream, response.Headers.ContentType) 
            { 
                FileDownloadName = fileName
            };
        }

        /// <summary>
        /// Delete file from the bucket
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="fileName"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public async Task DeleteDocumentFromBucket(string folderName, string fileName, string version)
        {
            using (var client = new AmazonS3Client(_accessKey, _secretKey, RegionEndpoint.USEast1))
            {
                var request = new DeleteObjectRequest()
                {
                    BucketName = _bucketName,
                    Key = $"{folderName}/{fileName}",
                    VersionId = version
                };

                await client.DeleteObjectAsync(request);
            }
        }
        public async Task DeleteDocumentsFromBucket(List<KeyVersion> keyVersions)
        {
            using (var client = new AmazonS3Client(_accessKey, _secretKey, RegionEndpoint.USEast1))
            {
                var request = new DeleteObjectsRequest()
                {
                    BucketName = _bucketName,
                    Objects = keyVersions

                };

                await client.DeleteObjectsAsync(request);
                
            }
        }


    }
}
