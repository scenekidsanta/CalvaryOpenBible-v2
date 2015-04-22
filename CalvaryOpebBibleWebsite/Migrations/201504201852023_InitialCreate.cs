namespace CalvaryOpebBibleWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Belief",
                c => new
                    {
                        BeliefID = c.Int(nullable: false, identity: true),
                        BeliefTitle = c.String(nullable: false),
                        BeliefDetails = c.String(),
                    })
                .PrimaryKey(t => t.BeliefID);
            
            CreateTable(
                "dbo.Calendar",
                c => new
                    {
                        CalendarID = c.Int(nullable: false, identity: true),
                        Month = c.String(nullable: false),
                        Day = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CalendarID);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventType = c.String(nullable: false),
                        EventMinistry = c.String(nullable: false),
                        EventName = c.String(nullable: false),
                        EventLocation = c.String(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                        EventCoordinator = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pastor",
                c => new
                    {
                        PastorID = c.Int(nullable: false, identity: true),
                        PastorName = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.PastorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pastor");
            DropTable("dbo.Image");
            DropTable("dbo.Event");
            DropTable("dbo.Calendar");
            DropTable("dbo.Belief");
        }
    }
}
