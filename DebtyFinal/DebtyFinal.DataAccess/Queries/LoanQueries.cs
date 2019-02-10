using DebtyFinal.Interfaces;
using DebtyFinal.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

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

        public List<Loan> GetLoans(Guid userID)
        {
            IQueryable<Loan> loans = null;
            try
            {
                using (var context = new DebtyDBContext())
                {
                    loans = from loan in context.Loans
                            where loan.Creditor.Id == userID.ToString()
                            select new Loan()
                            {
                                LoanID = loan.LoanID,
                                LoanName = loan.LoanName,
                                LoanDate = loan.LoanDate,
                                LoanDesc = loan.LoanDesc,
                                Creditor = new Creditor { FirstName = loan.Creditor.FirstName, LastName = loan.Creditor.LastName },
                                Deadline = loan.Deadline
                            };
                    return loans.ToList();
                }
            }
            catch (Exception ex)
            {
                return loans.DefaultIfEmpty().ToList();
            }

        }

        public List<Loan> GetLoans(string userID)
        {
            List<Loan> loans = null;
            try
            {
                using (var context = new DebtyDBContext())
                {
                    var debtors = (from debtorloan in context.DebtorLoans
                                   join debtor in context.Persons on debtorloan.DebtorID equals debtor.Id
                                   select new
                                   {
                                       loanID = debtorloan.LoanID,
                                       debtor = new Debtor { FirstName = debtor.FirstName, LastName = debtor.LastName }
                                   }).ToList();

                    loans = (from loan in context.Loans
                                   join creditor in context.Persons on loan.Creditor.Id equals creditor.Id
                                   where loan.Creditor.Id == userID
                                   select new Loan()
                                   {
                                       LoanID = loan.LoanID,
                                       LoanName = loan.LoanName,
                                       LoanDesc = loan.LoanDesc,
                                       LoanDate = loan.LoanDate,
                                       Deadline = loan.Deadline,
                                       LoanAmount = loan.LoanAmount,
                                       Creditor = new Creditor { FirstName = creditor.FirstName,LastName=creditor.LastName}
                                   }).ToList();

                    for(int i = 0; i <= loans.Count; i++)
                    {
                        if(debtors[i].loanID == loans[i].LoanID)
                        {
                            loans[i].Debtors.Add(debtors[i].debtor);
                        }
                    }

                    return loans;
                }
            }
            catch (Exception ex)
            {
                return loans.DefaultIfEmpty().ToList();
            }
        }

        public void UpdateLoan()
        {
            throw new NotImplementedException();
        }
    }
}
