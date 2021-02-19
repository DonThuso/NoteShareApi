using System;
using System.Collections.Generic;
using System.Text;

namespace ShareNoteAppApi.Domain.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid? UserId { get; set; }
        public virtual User AccountUser {get;set;}
        public Guid AccountLookup { get; set; }
    }
}
