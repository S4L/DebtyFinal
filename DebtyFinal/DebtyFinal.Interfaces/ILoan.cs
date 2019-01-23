using DebtyFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Interfaces
{
    public interface ILoan
    {
        List<Loan> GetLoansByUserID(string userID);
        void AddLoan();
        void UpdateLoan();
        void DeleteLoan();
    }
}
