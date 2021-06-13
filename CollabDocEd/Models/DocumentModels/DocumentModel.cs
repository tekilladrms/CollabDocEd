using CollabDocEd.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Models.DocumentModels
{
    public class DocumentModel
    {
        [Display(Name = "Description")]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int ProjectId { get; set; }
        public string Creator { get; set; }

        [Required]
        public IFormFile file { get; set; }
        
    }
}
