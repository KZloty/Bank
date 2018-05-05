using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Bank.Domain.Entities;

namespace Bank.WebUI.Models
{
    public class AplikantDbContext : DbContext
    {
        DbSet<Bank.Domain.Entities.Aplikant> Aplikanci { get; set; }
    }
}