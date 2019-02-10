using System;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class Payment
    { 
        public Guid PaymentID { get; set; }
        public string PaymentName { get; set; }
        public string PaymentDesc { get; set; }
        public DateTime PaymentDate { get; set; }
        public Loan Loan { get; set; }
    }
}