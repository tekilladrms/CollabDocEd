using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollabDocEd.Domain;

namespace CollabDocEd.Models
{
    public class EditProfileViewModel
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
        
    }
}
