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
        [Required]
        public Guid LoanID { get; set; }

        [Required]
        public string LoanName { get; set; }

        public string LoanDesc { get; set; }

        [Required]
        public string LoanDate { get; set; }

        [Required]
        public string DeadLine { get; set; }

        [Required]
        public string LoanAmount { get; set; }

        [Required]
        public Payment Payment { get; set; }

        [Required]
        public Person Creditor { get; set; }

        [Required]
        public Person Debtor { get; set; }
    }
}
