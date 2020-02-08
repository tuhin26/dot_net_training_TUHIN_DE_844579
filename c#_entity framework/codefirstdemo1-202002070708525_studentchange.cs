namespace codefirstdemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.students", "department", c => c.String());
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.students", "department");
        }
    }
}
