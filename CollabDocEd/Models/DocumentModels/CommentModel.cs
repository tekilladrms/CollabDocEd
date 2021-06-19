using CollabDocEd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Models.DocumentModels
{
    public class CommentModel
    {
        public int ProjectId { get; set; }
        public string Text { get; set; }
        public string UserEmail { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
