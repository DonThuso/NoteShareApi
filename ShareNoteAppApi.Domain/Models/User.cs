using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string School { get; set; }
        public string SchoolLevel { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid UpdatedById { get; set; }
        public virtual User UpdatedByUser { get; set; }
        public Guid UserLookup { get; set; }
    }
}
