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

        public List<Loan> GetLoansByUserID(string userID)
        {
            List<Loan> Loans = new List<Loan>();
            using (var context = new DebtyDBContext())
            {
                var loans = from loan in context.Loans
                            join person in context.Persons
                            on new { loan.Creditor.Id } equals new { person.Id }
                            select new { loan.LoanID, loan.LoanName, loan.LoanDesc, loan.LoanDate, loan.Deadline, loan.LoanAmount,loan.Creditor };

                var debtorloans = from debtorloan in context.DebtorLoans
                                  join l in loans
                                  on new {debtorloan.LoanID} equals new { l.LoanID }
                                  select new { }
            }

            return Loans;
        }

        public void UpdateLoan()
        {
            throw new NotImplementedException();
        }
    }
}
