using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bank.WebUI.Models
{
    public class BankWebUIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BankWebUIContext() : base("name=BankWebUIContext")
        {
        }

        public System.Data.Entity.DbSet<Bank.WebUI.Models.ApplicationForm> ApplicationForms { get; set; }

        public System.Data.Entity.DbSet<Bank.Entities.Klient> Klients { get; set; }

        public System.Data.Entity.DbSet<Bank.Entities.Adres> Adres { get; set; }

        public System.Data.Entity.DbSet<Bank.Entities.Telefon> Telefons { get; set; }

        public System.Data.Entity.DbSet<Bank.WebUI.Models.KlientViewModel> KlientViewModels { get; set; }
    }
}
