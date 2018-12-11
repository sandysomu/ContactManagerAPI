using System;
using System.Collections.Generic;
using System.Text;

namespace ContentManagerAPI.Database.Models
{
   public class ContactsInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }

    }
}
