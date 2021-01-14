namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                {
                    BookId = c.Int(nullable: false, identity: true),
                    BookTypeId = c.Int(nullable: false),
                    BookTitle = c.String(),
                    BookAuthor = c.String(),
                    DateAdded = c.DateTime(nullable: false),
                    FileName = c.String(),
                    BookDescription = c.String(),
                    BookPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    isBestseller = c.Boolean(nullable: false),
                    isHidden = c.Boolean(nullable: false),
                    ShortDescription = c.String(),
                })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.BookTypes", t => t.BookTypeId, cascadeDelete: true)
                .Index(t => t.BookTypeId);

            CreateTable(
                "dbo.BookTypes",
                c => new
                {
                    BookTypeId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    IconFileName = c.String(),
                })
                .PrimaryKey(t => t.BookTypeId);

            CreateTable(
                "dbo.OrderItems",
                c => new
                {
                    OrderItemId = c.Int(nullable: false, identity: true),
                    OrderId = c.Int(nullable: false),
                    BookId = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.BookId);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderId = c.Int(nullable: false, identity: true),
                    UserId = c.String(),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Address = c.String(),
                    CodeAndCity = c.String(),
                    PhoneNumber = c.String(),
                    Email = c.String(),
                    Comment = c.String(),
                    DateCreated = c.DateTime(nullable: false),
                    OrderState = c.Int(nullable: false),
                    TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.OrderId);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "BookTypeId", "dbo.BookTypes");
            DropIndex("dbo.OrderItems", new[] { "BookId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Books", new[] { "BookTypeId" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItems");
            DropTable("dbo.BookTypes");
            DropTable("dbo.Books");
        }
    }
}
