using DebtyFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DebtyFinal.DataAccess
{
    public class DebtyDBContext : DbContext
    {
        const string connectionString = "Server=(local)\\sqlexpress;Database=DebtyDB;Trusted_Connection=True;MultipleActiveResultSets=True";
        public DebtyDBContext() : base(){}
        public DebtyDBContext(DbContextOptions<DebtyDBContext> options) : base(options) { }
        public DbSet<Person> Person { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
