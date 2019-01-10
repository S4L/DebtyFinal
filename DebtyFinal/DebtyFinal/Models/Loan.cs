using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DebtyFinal.Models
{
    public class Loan
    {
        [Key]
        public Guid LoanID { get; set; }
        public string LoanName { get; set; }
        public string LoanDesc { get; set; }
        public string LoanDate { get; set; }
        public string DeadLine { get; set; }
        public string LoanAmount { get; set; }
        public Payment Payment { get; set; }
        public Person Creditor { get; set; }
        public Person Debtor { get; set; }
    }
}
