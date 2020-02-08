namespace codefirstdemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentcreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);

           



            CreateTable(
                "dbo.teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),//
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.teachers");
            DropTable("dbo.students");
        }
    }
}
