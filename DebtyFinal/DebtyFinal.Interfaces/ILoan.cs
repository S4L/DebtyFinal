using DebtyFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Interfaces
{
    public interface ILoan
    {
        List<LoanDTO> GetLoansByUserID(string userID);
        void AddLoan();
        void UpdateLoan();
        void DeleteLoan();
    }
}
