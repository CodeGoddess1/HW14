namespace DataBase_Design.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Number = c.Int(nullable: false),
                        DepartmentTypes = c.String(),
                    })
                .PrimaryKey(t => t.ClassID);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ScoreID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DateAssigned = c.DateTime(nullable: false),
                        DateDue = c.DateTime(nullable: false),
                        DateSubmit = c.DateTime(nullable: false),
                        PointsEarned = c.Int(nullable: false),
                        PointsPossible = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScoreID);
            
            CreateTable(
                "dbo.ScoreTypes",
                c => new
                    {
                        ScoreTypeID = c.Int(nullable: false, identity: true),
                        Types = c.String(),
                    })
                .PrimaryKey(t => t.ScoreTypeID);
            
            CreateTable(
                "dbo.SCS",
                c => new
                    {
                        SCSID = c.Int(nullable: false, identity: true),
                        ClassID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        ScoreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SCSID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Scores", t => t.ScoreID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.ClassID)
                .Index(t => t.StudentID)
                .Index(t => t.ScoreID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SSN = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.Int(nullable: false),
                        PhoneNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SCS", "StudentID", "dbo.Students");
            DropForeignKey("dbo.SCS", "ScoreID", "dbo.Scores");
            DropForeignKey("dbo.SCS", "ClassID", "dbo.Classes");
            DropIndex("dbo.SCS", new[] { "ScoreID" });
            DropIndex("dbo.SCS", new[] { "StudentID" });
            DropIndex("dbo.SCS", new[] { "ClassID" });
            DropTable("dbo.Students");
            DropTable("dbo.SCS");
            DropTable("dbo.ScoreTypes");
            DropTable("dbo.Scores");
            DropTable("dbo.Classes");
        }
    }
}
