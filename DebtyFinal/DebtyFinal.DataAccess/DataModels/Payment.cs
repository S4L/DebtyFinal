using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaymentAmount { get; set; }

        public Debtor Debtor { get; set; }
        public Loan Loan { get; set; }
    }
}
