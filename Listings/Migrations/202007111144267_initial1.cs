namespace Listings.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Listings", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Listings", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Listings", "Address", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Listings", "Address", c => c.String());
            AlterColumn("dbo.Listings", "Description", c => c.String());
            AlterColumn("dbo.Listings", "Name", c => c.String());
        }
    }
}
