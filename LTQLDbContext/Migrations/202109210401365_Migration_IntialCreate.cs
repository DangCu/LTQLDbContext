namespace LTQLDbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128, unicode: false),
                        NameStudent = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
