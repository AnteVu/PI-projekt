namespace BusinessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projection", "Teatre_Id", c => c.Int());
            CreateIndex("dbo.Projection", "Teatre_Id");
            AddForeignKey("dbo.Projection", "Teatre_Id", "dbo.Teatre", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projection", "Teatre_Id", "dbo.Teatre");
            DropIndex("dbo.Projection", new[] { "Teatre_Id" });
            DropColumn("dbo.Projection", "Teatre_Id");
        }
    }
}
