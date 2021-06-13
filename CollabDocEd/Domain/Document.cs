using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Domain
{
    public class Document
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public int Proj { get; set; }
        public string Creator { get; set; }
        public string Filename { get; set; }
        public string FileVersion { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
