namespace Bank.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial22512 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Telefons", "KlientID", "dbo.Klients");
            DropForeignKey("dbo.Adres", "KlientID", "dbo.Klients");
            DropIndex("dbo.Adres", new[] { "KlientID" });
            DropIndex("dbo.Telefons", new[] { "KlientID" });
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            DropTable("dbo.Adres");
            DropTable("dbo.Klients");
            DropTable("dbo.Telefons");
            DropTable("dbo.ApplicationForms");
        }
        
        public override void Down()
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
            
            CreateTable(
                "dbo.Telefons",
                c => new
                    {
                        TelefonID = c.Int(nullable: false, identity: true),
                        KlientID = c.Int(nullable: false),
                        NumerTelefonu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TelefonID);
            
            CreateTable(
                "dbo.Klients",
                c => new
                    {
                        KlientID = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(),
                        PESEL = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KlientID);
            
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
                .PrimaryKey(t => t.AdresID);
            
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            CreateIndex("dbo.Telefons", "KlientID");
            CreateIndex("dbo.Adres", "KlientID");
            AddForeignKey("dbo.Adres", "KlientID", "dbo.Klients", "KlientID", cascadeDelete: true);
            AddForeignKey("dbo.Telefons", "KlientID", "dbo.Klients", "KlientID", cascadeDelete: true);
        }
    }
}
