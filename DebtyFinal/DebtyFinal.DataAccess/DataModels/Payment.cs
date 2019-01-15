using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DebtyFinal.DataAccess.DataModels
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; }
        public string PaymentDesc { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public decimal PaymentAmount { get; set; }

        public Debtor Debtor { get; set; }
        public Loan Loan { get; set; }
    }
}
