using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Domain
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
