using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Models
{
    public class Debtor: Person
    {
        public List<Payment> Payments { get; set; }
    }
}
