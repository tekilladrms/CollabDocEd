using Amazon.S3;
using Amazon.S3.Model;
using CollabDocEd.AmazonS3;
using CollabDocEd.Domain;
using CollabDocEd.EF;
using CollabDocEd.Models;
using CollabDocEd.Models.DocumentModels;
using CollabDocEd.Models.ProjectModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Controllers
{
    [Authorize]
    public class DocumentController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public DocumentController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocuments(int id)
        {
            //Get project
            Project project = await _context.Projects.Include(p => p.Documents).FirstOrDefaultAsync(item => item.Id == id);

            return PartialView("_AllDocuments", new AllDocumentsModel() 
            { 
                Creator = project.CreatorEmail,
                Documents = project.Documents,
                ProjectId = project.Id
            });
        }

        [HttpGet]
        public IActionResult AddDocument(int projectId)
        {
            var vm = new DocumentModel();
            vm.ProjectId = projectId;
            return PartialView("_AddDocumentModalView", vm);
        }


        [HttpPost]
        public async Task<IActionResult> AddDocument(DocumentModel vm)
        {
            if(vm.file == null)
            {
                return PartialView("_AddDocumentModalView", vm);
            }

            //Get current user and project from db
            ApplicationUser user = await _userManager.GetUserAsync(User);
            Project project = await _context.Projects
                .Include(p => p.Documents)
                .Include(p => p.Comments)
                .FirstOrDefaultAsync(item => item.Id == vm.ProjectId);

            //Create document
            Document document = new Document();
            document.Creator = user.Email;
            document.Description = vm.Description;
            document.Filename = vm.file.FileName;
            

            //Upload file to Amazon and get version
            var s3 = new AmazonS3Service();
            document.FileVersion = await s3.UploadDocumentToBucket(vm.file, project.Name);
            
            if (!string.IsNullOrEmpty(document.FileVersion))
            {
                project.Documents.Add(document);
                _context.Update(project);
                await _context.SaveChangesAsync();
            }
            List<IOnScreen> onScreens = new List<IOnScreen>();
            onScreens.AddRange(project.Documents);
            onScreens.AddRange(project.Comments);
            onScreens.GroupBy(item => item.Created);
            return PartialView("_AllDocuments", new AllDocumentsModel()
            {
                Documents = project.Documents,
                Creator = project.CreatorEmail,
                ProjectId = project.Id,
            });
        }

        public async Task<FileStreamResult> DownloadFile(int id)
        {
            var document = await _context.Documents.FirstOrDefaultAsync(item => item.Id == id);
            var project = await _context.Projects.FirstOrDefaultAsync(item => item.Id == document.Proj);
            var s3 = new AmazonS3Service();
            var result = await s3.DownloadDocumentFromBucket(project.Name, document.Filename, document.FileVersion);
            
            return result;
        }
        

        public async Task<IActionResult> DeleteFile(int projectId, int fileId)
        {
            //get document and project

            var document = await _context.Documents.FirstOrDefaultAsync(item => item.Id == fileId);
            var project = await _context.Projects.Include(p => p.Documents).FirstOrDefaultAsync(item => item.Id == projectId);

            //delete document from Amazon storage
            var s3 = new AmazonS3Service();
            await s3.DeleteDocumentFromBucket(project.Name, document.Filename, document.FileVersion);

            //delete document from database
            project.Documents.Remove(document);
            _context.Update(project);
            await _context.SaveChangesAsync();

            return PartialView("_AllDocuments", new AllDocumentsModel()
            {
                Creator = project.CreatorEmail,
                Documents = project.Documents, 
                ProjectId = project.Id
            });

        }


        [HttpGet]
        public async Task<IActionResult> GetAllComments(int documentId)
        {
            var document = await _context.Documents.Include(d => d.Comments).FirstOrDefaultAsync(item => item.Id == documentId);
            return PartialView("_AllComments", new AllCommentsModel()
            { 
                Comments = document.Comments,
                DocumentId = document.Id
            });
        }

    }
}
