using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Models
{
    public class DebtorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PaymentDTO> Payments { get; set; }
    }
}
