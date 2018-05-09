namespace Bank.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2250 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        AdresID = c.Int(nullable: false, identity: true),
                        KlientID = c.Int(nullable: false),
                        Miasto = c.String(nullable: false, maxLength: 20),
                        KodPocztowy = c.Int(),
                        Ulica = c.String(),
                        NumerDomu = c.String(),
                    })
                .PrimaryKey(t => t.AdresID)
                .ForeignKey("dbo.Klients", t => t.KlientID, cascadeDelete: true)
                .Index(t => t.KlientID);
            
            CreateTable(
                "dbo.Klients",
                c => new
                    {
                        KlientID = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(),
                        PESEL = c.Int(),
                    })
                .PrimaryKey(t => t.KlientID);
            
            CreateTable(
                "dbo.Telefons",
                c => new
                    {
                        TelefonID = c.Int(nullable: false, identity: true),
                        KlientID = c.Int(nullable: false),
                        NumerTelefonu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TelefonID)
                .ForeignKey("dbo.Klients", t => t.KlientID, cascadeDelete: true)
                .Index(t => t.KlientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adres", "KlientID", "dbo.Klients");
            DropForeignKey("dbo.Telefons", "KlientID", "dbo.Klients");
            DropIndex("dbo.Telefons", new[] { "KlientID" });
            DropIndex("dbo.Adres", new[] { "KlientID" });
            DropTable("dbo.Telefons");
            DropTable("dbo.Klients");
            DropTable("dbo.Adres");
        }
    }
}
