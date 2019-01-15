using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DebtyFinal.DataAccess.DataModels
{
    public class DebtorLoan
    {
        [Required]
        public Guid DebtorID { get; set; }
        public Debtor Debtor { get; set; }

        
        public Guid LoanID { get; set; }
        public Loan Loan { get; set; }
    }
}
