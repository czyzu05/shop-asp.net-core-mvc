namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveShortDescription : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "ShortDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "ShortDescription", c => c.String());
        }
    }
}
