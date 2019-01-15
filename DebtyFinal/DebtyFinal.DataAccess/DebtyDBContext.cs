using DebtyFinal.DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DebtyFinal.DataAccess
{
    public class DebtyDBContext : DbContext
    {
        const string connectionString = "Server=.;Database=DebtyDB;Trusted_Connection=True;MultipleActiveResultSets=True";
        public DbSet<Person> Persons { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<DebtorLoan> DebtorLoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DebtorLoan>().HasKey(dl => new { dl.DebtorID, dl.LoanID });
        }
    }
}
