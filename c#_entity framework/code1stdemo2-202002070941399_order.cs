namespace code1stdemo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class order : DbMigration
    {
        public override void Up()
        {
            Sql("insert  into order values(1,'book',1)");
        }
        
        public override void Down()
        {
        }
    }
}
