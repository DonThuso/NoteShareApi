using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UpdatedById { get; set; }
        public int CreatedById { get; set; }
        public virtual User UpdateByUser { get; set; }
        public virtual User CreatedByUser { get; set; }
        public Guid TopicLookup { get; set; }
    }
}
