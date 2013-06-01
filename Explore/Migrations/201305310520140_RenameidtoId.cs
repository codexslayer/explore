namespace Explore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameidtoId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        LastPasswordAt = c.DateTime(nullable: false),
                        InActiveDate = c.DateTime(nullable: false),
                        NeedPasswordChange = c.Boolean(nullable: false),
                        Mobile = c.String(),
                        Email = c.String(),
                        Department_Id = c.Int(),
                        Designation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Designations", t => t.Designation_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Designation_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Designation_Id" });
            DropIndex("dbo.Users", new[] { "Department_Id" });
            DropForeignKey("dbo.Users", "Designation_Id", "dbo.Designations");
            DropForeignKey("dbo.Users", "Department_Id", "dbo.Departments");
            DropTable("dbo.Designations");
            DropTable("dbo.Departments");
            DropTable("dbo.Users");
        }
    }
}
