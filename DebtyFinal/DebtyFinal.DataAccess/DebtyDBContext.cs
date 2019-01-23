using DebtyFinal.DataAccess.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DebtyFinal.DataAccess
{
    public class DebtyDBContext : IdentityDbContext<Person>
    {
        public DebtyDBContext(DbContextOptions options) : base(options)
        {
        }

        public DebtyDBContext() : base()
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<DebtorLoan> DebtorLoans { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<DebtorLoan>().HasKey(dl => new { dl.DebtorID, dl.LoanID });
            builder.Entity<DebtorLoan>()
                .HasOne(dl => dl.Debtor)
                .WithMany(dl => dl.DebtorLoans)
                .HasForeignKey(dl => dl.DebtorID);
            builder.Entity<DebtorLoan>()
               .HasOne(dl => dl.Loan)
               .WithMany(dl => dl.DebtorLoans)
               .HasForeignKey(dl => dl.LoanID);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
