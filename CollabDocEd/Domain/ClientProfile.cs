﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CollabDocEd.Domain
{
    public class ClientProfile
    {
        [Key]
        [ForeignKey("IdentityUser")]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public virtual List<Project> Projects { get; set; }

    }
}
