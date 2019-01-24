using DebtyFinal.Interfaces;
using DebtyFinal.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.DataAccess.Repositories
{
    public class LoanQueries : ILoan
    {
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
            IQueryable<LoanDTO> loans = null;
            using (var context = new DebtyDBContext())
            {
                 loans = from loan in context.Loans
                            where loan.Creditor.Id == userID
                            select new LoanDTO()
                            {
                                LoanID = loan.LoanID,
                                LoanName = loan.LoanName,
                                LoanDate = loan.LoanDate,
                                LoanDesc = loan.LoanDesc,
                                Creditor = new CreditorDTO { FirstName = loan.Creditor.FirstName, LastName = loan.Creditor.LastName},
                                Deadline = loan.Deadline
                            };
                return loans.ToList();
            }
        }

        public void UpdateLoan()
        {
            throw new NotImplementedException();
        }
    }
}
