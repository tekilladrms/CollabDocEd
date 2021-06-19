using CollabDocEd.Models.ProjectModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Domain
{
    public class Comment : IOnScreen
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public string Creator { get; set; }
        public string Filename { get; set; } = null;
        public string FileVersion { get; set; } = null;
        public virtual ApplicationUser User { get; set; }
        public virtual Document Document { get; set; }
    }
}
