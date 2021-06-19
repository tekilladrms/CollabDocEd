using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollabDocEd.Models.ProjectModels
{
    public interface IOnScreen
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
        public string Filename { get; set; }
        public string FileVersion { get; set; }
    }
}
