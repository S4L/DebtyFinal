using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class Loan
    {
        public Guid LoanID { get; set; }
        public string LoanName { get; set; }
        public string LoanDesc { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime Deadline { get; set; }
        public Person Creditor { get; set; }
        public List<Person> Debtors { get; set; }
        public List<Payment> Payments { get; set; }
    }
}