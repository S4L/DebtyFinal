using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Models
{
    public class Creditor : Person
    {
        public List<Loan> Loans { get; set; }
    }
}
