namespace BusinessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "ShowDateFrom", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "ShowDateTo", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movie", "LastShowed", c => c.DateTime());
            DropColumn("dbo.Movie", "ShowDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "ShowDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movie", "LastShowed", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movie", "ShowDateTo");
            DropColumn("dbo.Movie", "ShowDateFrom");
        }
    }
}
