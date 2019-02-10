using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Models
{
    public class Debtor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
