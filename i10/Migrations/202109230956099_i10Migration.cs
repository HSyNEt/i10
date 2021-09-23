namespace i10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class i10Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.iCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        account_id = c.String(),
                        product_id = c.Int(nullable: false),
                        product_name = c.String(),
                        product_descript = c.String(),
                        product_price = c.String(),
                        product_qua = c.Int(nullable: false),
                        product_img = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.iOrders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        product_id = c.Int(nullable: false),
                        product_name = c.String(),
                        account_id = c.String(),
                        order_delivery = c.String(),
                        order_price = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.iProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.String(),
                        Img = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.iProducts");
            DropTable("dbo.iOrders");
            DropTable("dbo.iCarts");
        }
    }
}
