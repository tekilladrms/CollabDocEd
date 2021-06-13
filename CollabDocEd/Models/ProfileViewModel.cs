using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CollabDocEd.Domain;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CollabDocEd.Models
{
    public class ProfileViewModel : PageModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required]
        public List<Project> Projects { get; set; }
    }
}
