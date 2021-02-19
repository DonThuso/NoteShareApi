using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Models
{
    public class Note
    {
        public int NoteId { get; set; } 
        public String Type { get; set; }
        public Guid  SubjectId { get; set; }
        public Guid  TopicId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid UpdatedById { get; set; }
        public Guid CreatedById { get; set; }
        public virtual User UpdateByUser { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Topic Topic { get; set; }
        public Guid NoteLookup { get; set; }
    }
}
