namespace DataBase_Design.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "Instructor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Classes", "Instructor");
        }
    }
}
