namespace BusinessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.Int(nullable: false),
                        LastShowed = c.DateTime(nullable: false),
                        NumOfShowing = c.Int(nullable: false),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genre", t => t.Genre_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Hall",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        Teatre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teatre", t => t.Teatre_Id)
                .Index(t => t.Teatre_Id);
            
            CreateTable(
                "dbo.Teatre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        OIB = c.String(),
                        Phone = c.String(),
                        EMail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projection",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeFrom = c.DateTime(nullable: false),
                        TimeTo = c.DateTime(nullable: false),
                        Hall_Id = c.Int(),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hall", t => t.Hall_Id)
                .ForeignKey("dbo.Movie", t => t.Movie_Id)
                .Index(t => t.Hall_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Projection_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projection", t => t.Projection_Id)
                .Index(t => t.Projection_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservation", "Projection_Id", "dbo.Projection");
            DropForeignKey("dbo.Projection", "Movie_Id", "dbo.Movie");
            DropForeignKey("dbo.Projection", "Hall_Id", "dbo.Hall");
            DropForeignKey("dbo.Hall", "Teatre_Id", "dbo.Teatre");
            DropForeignKey("dbo.Movie", "Genre_Id", "dbo.Genre");
            DropIndex("dbo.Reservation", new[] { "Projection_Id" });
            DropIndex("dbo.Projection", new[] { "Movie_Id" });
            DropIndex("dbo.Projection", new[] { "Hall_Id" });
            DropIndex("dbo.Hall", new[] { "Teatre_Id" });
            DropIndex("dbo.Movie", new[] { "Genre_Id" });
            DropTable("dbo.Reservation");
            DropTable("dbo.Projection");
            DropTable("dbo.Teatre");
            DropTable("dbo.Hall");
            DropTable("dbo.Movie");
            DropTable("dbo.Genre");
        }
    }
}
