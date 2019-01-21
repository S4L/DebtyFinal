using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Interfaces.ModelInterfaces
{
    public interface ILoan
    {
        Guid LoanID { get; set; }
        string LoanName { get; set; }
        string LoanDesc { get; set; }
        DateTime LoanDate { get; set; }
        DateTime Deadline { get; set; }
        decimal LoanAmount { get; set; }
    }
}
