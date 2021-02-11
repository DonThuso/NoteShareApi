using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Models
{
    public class Note
    {
        public int NoteId { get; set; } 
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public String Type { get; set; }
        public int UpdatedById { get; set; }
        public int  SubjectId { get; set; }
        public int  TopicId { get; set; }
    }
}
