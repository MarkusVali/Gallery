using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Core.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
