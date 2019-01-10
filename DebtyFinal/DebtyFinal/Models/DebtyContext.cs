using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtyFinal.Models
{
    public class DebtyContext:DbContext
    {
        public DebtyContext(DbContextOptions<DebtyContext> options):base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
