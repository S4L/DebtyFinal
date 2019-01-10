using System;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; }
        public double PayAmount { get; set; }
        public DateTime PayDate { get; set; }
        
    }
}