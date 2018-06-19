namespace CoffeeShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        content = c.String(),
                        creationDate = c.DateTime(nullable: false),
                        active = c.Boolean(nullable: false),
                        description = c.String(),
                        img = c.String(),
                        author = c.String(),
                        type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        img = c.String(),
                        description = c.String(),
                        country = c.String(),
                        sort = c.String(),
                        brand = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        minAmount = c.Int(nullable: false),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        creationDate = c.DateTime(nullable: false),
                        age = c.Int(nullable: false),
                        content = c.String(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        img = c.String(),
                        title = c.String(),
                        description = c.String(),
                        pageSrc = c.String(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
            DropTable("dbo.Reviews");
            DropTable("dbo.Products");
            DropTable("dbo.Articles");
        }
    }
}
