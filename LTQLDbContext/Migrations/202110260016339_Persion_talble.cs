namespace LTQLDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Persion_talble : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persions",
                c => new
                    {
                        PersionID = c.Int(nullable: false, identity: true),
                        PersionName = c.String(),
                    })
                .PrimaryKey(t => t.PersionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persions");
        }
    }
}
