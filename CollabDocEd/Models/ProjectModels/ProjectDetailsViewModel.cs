using CollabDocEd.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Models.ProjectModels
{
    public class ProjectDetailsViewModel
    {
        public int Id { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsFinished { get; set; }

        public List<Document> Documents { get; set; }
        public List<Comment> Comments { get; set; }
        public List<IdentityUser> Users { get; set; }


        
    }
}
