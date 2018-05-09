namespace Bank.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2251 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Klients", "PESEL", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Klients", "PESEL", c => c.Int());
        }
    }
}
