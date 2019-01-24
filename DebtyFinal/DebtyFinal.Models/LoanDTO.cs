using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class LoanDTO
    {
        public Guid LoanID { get; set; }
        public string LoanName { get; set; }
        public string LoanDesc { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime Deadline { get; set; }
        public CreditorDTO Creditor { get; set; }
        public List<DebtorDTO> Debtors { get; set; }
        public List<PaymentDTO> Payments { get; set; }
    }
}