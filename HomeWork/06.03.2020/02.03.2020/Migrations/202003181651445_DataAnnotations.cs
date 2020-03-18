namespace _02._03._2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Barbers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Barbers", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Barbers", "Patronymic", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Barbers", "Sex", c => c.String(nullable: false));
            AlterColumn("dbo.Barbers", "Phone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Barbers", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Services", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Patronymic", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.EstimationsTypes", "Type", c => c.String(nullable: false, maxLength: 510));
            AlterColumn("dbo.Feedbacks", "Message", c => c.String(nullable: false));
            AlterColumn("dbo.Positions", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Positions", "Name", c => c.String());
            AlterColumn("dbo.Feedbacks", "Message", c => c.String());
            AlterColumn("dbo.EstimationsTypes", "Type", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "Patronymic", c => c.String());
            AlterColumn("dbo.Customers", "Surname", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Services", "Name", c => c.String());
            AlterColumn("dbo.Barbers", "Email", c => c.String());
            AlterColumn("dbo.Barbers", "Phone", c => c.String());
            AlterColumn("dbo.Barbers", "Sex", c => c.String());
            AlterColumn("dbo.Barbers", "Patronymic", c => c.String());
            AlterColumn("dbo.Barbers", "Surname", c => c.String());
            AlterColumn("dbo.Barbers", "Name", c => c.String());
        }
    }
}
