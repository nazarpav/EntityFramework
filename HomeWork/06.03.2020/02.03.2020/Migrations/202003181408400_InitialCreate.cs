namespace _02._03._2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        Sex = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        EmploymentDate = c.DateTime(nullable: false),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.BarbersServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServicesId = c.Int(nullable: false),
                        BarberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.BarberId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServicesId, cascadeDelete: true)
                .Index(t => t.ServicesId)
                .Index(t => t.BarberId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estimations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BarberId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        EstimationsTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.BarberId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.EstimationsTypes", t => t.EstimationsTypeId, cascadeDelete: true)
                .Index(t => t.BarberId)
                .Index(t => t.CustomerId)
                .Index(t => t.EstimationsTypeId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        CustomerId = c.Int(nullable: false),
                        BarbersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.BarbersId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.BarbersId);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BarbersID = c.Int(nullable: false),
                        Date_Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.BarbersID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.BarbersID);
            
            CreateTable(
                "dbo.EstimationsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BarberId = c.Int(nullable: false),
                        Day = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barbers", t => t.BarberId, cascadeDelete: true)
                .Index(t => t.BarberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shedules", "BarberId", "dbo.Barbers");
            DropForeignKey("dbo.Barbers", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Estimations", "EstimationsTypeId", "dbo.EstimationsTypes");
            DropForeignKey("dbo.Records", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Records", "BarbersID", "dbo.Barbers");
            DropForeignKey("dbo.Feedbacks", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Feedbacks", "BarbersId", "dbo.Barbers");
            DropForeignKey("dbo.Estimations", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Estimations", "BarberId", "dbo.Barbers");
            DropForeignKey("dbo.BarbersServices", "ServicesId", "dbo.Services");
            DropForeignKey("dbo.BarbersServices", "BarberId", "dbo.Barbers");
            DropIndex("dbo.Shedules", new[] { "BarberId" });
            DropIndex("dbo.Records", new[] { "BarbersID" });
            DropIndex("dbo.Records", new[] { "CustomerId" });
            DropIndex("dbo.Feedbacks", new[] { "BarbersId" });
            DropIndex("dbo.Feedbacks", new[] { "CustomerId" });
            DropIndex("dbo.Estimations", new[] { "EstimationsTypeId" });
            DropIndex("dbo.Estimations", new[] { "CustomerId" });
            DropIndex("dbo.Estimations", new[] { "BarberId" });
            DropIndex("dbo.BarbersServices", new[] { "BarberId" });
            DropIndex("dbo.BarbersServices", new[] { "ServicesId" });
            DropIndex("dbo.Barbers", new[] { "PositionId" });
            DropTable("dbo.Shedules");
            DropTable("dbo.Positions");
            DropTable("dbo.EstimationsTypes");
            DropTable("dbo.Records");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Customers");
            DropTable("dbo.Estimations");
            DropTable("dbo.Services");
            DropTable("dbo.BarbersServices");
            DropTable("dbo.Barbers");
        }
    }
}
