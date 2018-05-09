using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.Implementation
{
    public class BankContext : DbContext
    {
        public BankContext() : base("DefaultConnection")
        {
            Database.SetInitializer<BankContext>(null);
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Phone> Phones { get; set; }
    }
}
