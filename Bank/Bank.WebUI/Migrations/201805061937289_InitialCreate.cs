namespace Bank.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationForms",
                c => new
                    {
                        ApplicationID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        PESEL = c.Int(nullable: false),
                        Miasto = c.String(),
                        KodPocztowy = c.Int(nullable: false),
                        Ulica = c.String(),
                        NumerDomu = c.String(),
                        NumerTelefonu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApplicationForms");
        }
    }
}
