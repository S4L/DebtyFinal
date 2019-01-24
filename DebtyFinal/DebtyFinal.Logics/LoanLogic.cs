using DebtyFinal.DataAccess.Repositories;
using DebtyFinal.Interfaces;
using DebtyFinal.Models;
using System;
using System.Collections.Generic;

namespace DebtyFinal.Logics
{
    public class LoanLogic : ILoan
    {
        private LoanQueries loanQueries;

        public LoanLogic()
        {
            loanQueries = new LoanQueries();
        }

        public void AddLoan()
        {
            throw new NotImplementedException();
        }

        public void DeleteLoan()
        {
            throw new NotImplementedException();
        }

        public List<LoanDTO> GetLoansByUserID(string userID)
        {
            return loanQueries.GetLoansByUserID(userID);
        }

        public void UpdateLoan()
        {
            throw new NotImplementedException();
        }
    }
}
