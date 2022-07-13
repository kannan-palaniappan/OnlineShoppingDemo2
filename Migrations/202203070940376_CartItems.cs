namespace OnlineShoppingDemo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartItems : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "CateId", "dbo.Categories");
            DropIndex("dbo.Carts", new[] { "CateId" });
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            DropTable("dbo.Carts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        ImageUrl = c.String(),
                        ImageUrl1 = c.String(),
                        ImageUrl2 = c.String(),
                        ImageUrl3 = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.CartItems", "Product_Id", "dbo.Products");
            DropIndex("dbo.CartItems", new[] { "Product_Id" });
            DropTable("dbo.CartItems");
            CreateIndex("dbo.Carts", "CateId");
            AddForeignKey("dbo.Carts", "CateId", "dbo.Categories", "CateId", cascadeDelete: true);
        }
    }
}
