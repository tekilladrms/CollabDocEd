using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Models.ProjectModels
{
    public class InviteUserToProjectModel
    {
        [Required]
        public string UserEmail { get; set; }
        public int ProjectId { get; set; }

    }
}
