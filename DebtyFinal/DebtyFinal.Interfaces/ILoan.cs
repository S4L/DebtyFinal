using DebtyFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Interfaces
{
    public interface ILoan
    {
        List<Loan> GetLoans(string userID);
        List<Loan> GetLoans(Guid userID);
        void AddLoan();
        void UpdateLoan();
        void DeleteLoan();
    }
}
