using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid UpdatedById { get; set; }
        public Guid CreatedById { get; set; }
        public virtual User UpdateByUser { get; set; }
        public virtual User CreatedByUser { get; set; }
        public Guid SubjectLookup { get; set; }
    }
}
