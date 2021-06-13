using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Models.ProjectModels
{
    public class AllUsersModel
    {
        public int ProjectId { get; set; }
        public string Creator { get; set; }
        public List<IdentityUser> Users { get; set; }
    }
}
