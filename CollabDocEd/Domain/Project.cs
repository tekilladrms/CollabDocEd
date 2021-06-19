
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Domain
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; } = false;
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public string CreatorEmail { get; set; }
        
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Document> Documents { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }

    }
}
