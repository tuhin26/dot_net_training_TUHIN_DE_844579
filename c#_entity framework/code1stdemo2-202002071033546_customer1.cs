namespace code1stdemo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.orders");
            AddColumn("dbo.orders", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.orders", "id");
            DropColumn("dbo.orders", "orderid");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.orders", "orderid", c => c.Int(nullable: false, identity: true));
            //DropPrimaryKey("dbo.orders");
            //DropColumn("dbo.orders", "id");
            //AddPrimaryKey("dbo.orders", "orderid");
        }
    }
}
