using System;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; }
        [Required]
        public double PayAmount { get; set; }
        [Required]
        public DateTime PayDate { get; set; }
        
    }
}