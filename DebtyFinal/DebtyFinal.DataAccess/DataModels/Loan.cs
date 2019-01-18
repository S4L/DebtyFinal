using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(18,2)")]
        public decimal LoanAmount { get; set; }

        [Required]
        public Creditor Creditor { get; set; }

        [Required]
        public List<DebtorLoan> DebtorLoans { get; set; }
    }
}