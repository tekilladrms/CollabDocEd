using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CollabDocEd.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace CollabDocEd.Models.ProjectModels
{
    public class CreateProjectViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public string Creator { get; set; }

        [Required]
        public IFormFile File { get; set; }

    }
}
