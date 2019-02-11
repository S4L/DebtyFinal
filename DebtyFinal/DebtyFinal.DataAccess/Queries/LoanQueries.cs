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
                    var loanss = (from loan in context.Loans
                                  join creditor in context.Persons on loan.Creditor.Id equals creditor.Id
                                  where loan.Creditor.Id == userID
                                  select new
                                  {
                                      loanID = loan.LoanID,
                                      loanName = loan.LoanName,
                                      loanDesc = loan.LoanDesc,
                                      loanDate = loan.LoanDate,
                                      deadline = loan.Deadline,
                                      loanAmount = loan.LoanAmount,
                                      Creditor = new Creditor { PersonID = loan.Creditor.Id, FirstName = creditor.FirstName, LastName = creditor.LastName },
                                  }).ToList();

                    var debtors = (from dl in context.DebtorLoans
                                   join debtor in context.Persons on dl.DebtorID equals debtor.Id
                                   select new
                                   {
                                       loanID = dl.LoanID,
                                       debtor = new Debtor { FirstName = debtor.FirstName, LastName = debtor.LastName }
                                   } into D
                                   group D by D.loanID into Debtors
                                   select new
                                   {
                                       loanID = Debtors.Key,
                                       Debtors = Debtors.ToList()
                                   }).ToList();

                    loans = (from loan in loanss
                             join debtor in debtors on loan.loanID equals debtor.loanID
                             select new Loan
                             {
                                 LoanID = loan.loanID,
                                 LoanName = loan.loanName,
                                 LoanDesc = loan.loanDesc,
                                 LoanDate = loan.loanDate,
                                 Deadline = loan.deadline,
                                 LoanAmount = loan.loanAmount,
                                 Creditor = loan.Creditor,
                                 Debtors = debtor.Debtors.Select(x => x.debtor).ToList()
                             }).ToList();

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
