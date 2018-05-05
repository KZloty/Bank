namespace Bank.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        AdresID = c.Int(nullable: false, identity: true),
                        AplikantID = c.Int(nullable: false),
                        Miasto = c.String(),
                        KodPocztowy = c.Int(nullable: false),
                        NumerDomu = c.String(),
                    })
                .PrimaryKey(t => t.AdresID)
                .ForeignKey("dbo.Aplikants", t => t.AplikantID, cascadeDelete: true)
                .Index(t => t.AplikantID);
            
            CreateTable(
                "dbo.Aplikants",
                c => new
                    {
                        AplikantID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        PESEL = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AplikantID);
            
            CreateTable(
                "dbo.NumerTelefonus",
                c => new
                    {
                        NumerTelefonuID = c.Int(nullable: false, identity: true),
                        Numer = c.Int(nullable: false),
                        AplikantID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NumerTelefonuID)
                .ForeignKey("dbo.Aplikants", t => t.AplikantID, cascadeDelete: true)
                .Index(t => t.AplikantID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NumerTelefonus", "AplikantID", "dbo.Aplikants");
            DropForeignKey("dbo.Adres", "AplikantID", "dbo.Aplikants");
            DropIndex("dbo.NumerTelefonus", new[] { "AplikantID" });
            DropIndex("dbo.Adres", new[] { "AplikantID" });
            DropTable("dbo.NumerTelefonus");
            DropTable("dbo.Aplikants");
            DropTable("dbo.Adres");
        }
    }
}
