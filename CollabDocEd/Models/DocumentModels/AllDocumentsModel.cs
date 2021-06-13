using CollabDocEd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace CollabDocEd.Models.DocumentModels
{
    public class AllDocumentsModel
    {
        public int ProjectId { get; set; }
        public List<Document> Documents { get; set; }
        public string Creator { get; set; }
    }
}
