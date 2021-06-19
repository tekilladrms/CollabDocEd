using CollabDocEd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace CollabDocEd.Models.DocumentModels
{
    public class AllCommentsModel
    {
        public int DocumentId { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
