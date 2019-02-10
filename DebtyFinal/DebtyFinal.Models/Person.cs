using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class Person
    {
        public Guid PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
