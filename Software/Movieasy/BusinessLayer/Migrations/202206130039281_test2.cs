namespace BusinessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movie", "ShowDateFrom");
            DropColumn("dbo.Movie", "ShowDateTo");
            DropColumn("dbo.Movie", "LastShowed");
            DropColumn("dbo.Movie", "NumOfShowing");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "NumOfShowing", c => c.Int(nullable: false));
            AddColumn("dbo.Movie", "LastShowed", c => c.DateTime());
            AddColumn("dbo.Movie", "ShowDateTo", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "ShowDateFrom", c => c.DateTime(nullable: false));
        }
    }
}
