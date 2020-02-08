namespace code1stdemo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customercreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                        country = c.String(),
                        city = c.String(),
                    })
                .PrimaryKey(t => t.customerId);
            //inserting data into table using raw sql queries
            Sql("insert into customers values(1,'tuhin','india','kolkata')");
            Sql("insert into customers values(2,'mohan','india','chennai')");
            Sql("insert into customers values(3,'imon','india','dehli')");

            CreateTable(
                "dbo.orders",
                c => new
                    {
                        orderid = c.Int(nullable:false, identity:false),
                        name = c.String(),
                        customerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.orderid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.orders");
            DropTable("dbo.customers");
        }
    }
}
