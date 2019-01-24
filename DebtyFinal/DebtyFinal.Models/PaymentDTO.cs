using System;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class PaymentDTO
    { 
        public Guid PaymentID { get; set; }
        public string PaymentName { get; set; }
        public string PaymentDesc { get; set; }
        public DateTime PaymentDate { get; set; }
        public LoanDTO Loan { get; set; }
    }
}