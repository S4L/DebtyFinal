using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DebtyFinal.DataAccess.DataModels
{
    public class Debtor:Person
    {
        [Required]
        public List<DebtorLoan> DebtorLoans { get; set; }
    }
}
