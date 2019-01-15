using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.DataAccess.DataModels
{
    public class Loan
    {
        [Key]
        public Guid LoanID { get; set; }
        [Required]
        public string LoanName { get; set; }
        public string LoanDesc { get; set; }
        [Required]
        public DateTime LoanDate { get; set; }
        public DateTime Deadline { get; set; }

        [Required]
        public decimal LoanAmount { get; set; }

        [Required]
        public Creditor Creditor { get; set; }

        [Required]
        public List<DebtorLoan> DebtorLoans { get; set; }
    }
}