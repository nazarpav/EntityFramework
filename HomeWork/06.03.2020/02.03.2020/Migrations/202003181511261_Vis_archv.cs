namespace _02._03._2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vis_archv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VisitingArchives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(),
                        Date = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(),
                        FeedbackId = c.Int(),
                        BarberId = c.Int(),
                        EstimationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.BarberId)
                .ForeignKey("dbo.Estimations", t => t.EstimationId)
                .ForeignKey("dbo.Feedbacks", t => t.FeedbackId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Services", t => t.ServiceId)
                .Index(t => t.ServiceId)
                .Index(t => t.CustomerId)
                .Index(t => t.FeedbackId)
                .Index(t => t.BarberId)
                .Index(t => t.EstimationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VisitingArchives", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.VisitingArchives", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.VisitingArchives", "FeedbackId", "dbo.Feedbacks");
            DropForeignKey("dbo.VisitingArchives", "EstimationId", "dbo.Estimations");
            DropForeignKey("dbo.VisitingArchives", "BarberId", "dbo.Barbers");
            DropIndex("dbo.VisitingArchives", new[] { "EstimationId" });
            DropIndex("dbo.VisitingArchives", new[] { "BarberId" });
            DropIndex("dbo.VisitingArchives", new[] { "FeedbackId" });
            DropIndex("dbo.VisitingArchives", new[] { "CustomerId" });
            DropIndex("dbo.VisitingArchives", new[] { "ServiceId" });
            DropTable("dbo.VisitingArchives");
        }
    }
}
