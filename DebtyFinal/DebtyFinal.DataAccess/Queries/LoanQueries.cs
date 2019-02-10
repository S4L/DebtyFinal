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
            catch(Exception ex)
            {
                return loans.DefaultIfEmpty().ToList();
            }
           
        }

        public List<Loan> GetLoans(string userID)
        {
            IQueryable<Loan> loans = null;
            try
            {
                using (var context = new DebtyDBContext())
                {
                    //var sth = context.Loans.Where(L => L.Creditor.Id == userID)
                    //    .Include(c => c.Creditor)
                    //    .Select(L => new Loan()
                    //    {
                    //        Creditor = new Creditor { FirstName = L.Creditor.FirstName, LastName = L.Creditor.LastName},
                    //         Deadline = L.Deadline,
                    //         LoanDate = L.LoanDate,
                    //         LoanDesc = L.LoanDesc,
                    //         LoanID = L.LoanID,
                    //         LoanName = L.LoanName
                    //     });

                    var sth = from loan in context.Loans
                              join person in context.Persons on loan.Creditor.Id equals person.Id
                              join debtor in context.DebtorLoans on loan.LoanID equals debtor.LoanID
                              where loan.Creditor.Id == userID
                              select new Loan()
                              {
                                  Creditor = new Creditor { FirstName = person.FirstName, LastName = person.LastName },
                                  Deadline = loan.Deadline,
                                  LoanDate = loan.LoanDate,
                                  LoanDesc = loan.LoanDesc,
                                  LoanID = loan.LoanID,
                                  LoanName = loan.LoanName
                              };
                    var sthelse = sth.ToList();
                    var debtors = (from d in context.DebtorLoans
                                   join s in sthelse on d.LoanID equals s.LoanID
                                   join p in context.Persons on d.DebtorID equals p.Id
                                   select new Debtor()
                                   {
                                       FirstName = p.FirstName,
                                       LastName = p.LastName
                                   }).ToList();

                    //var debtorList = debtors.ToList();

                    
                    var list = loans.ToList();


                    return list;
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
