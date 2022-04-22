namespace HR_Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HR : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Salary = c.Int(nullable: false),
                        Gender = c.String(),
                        City_ID = c.Int(nullable: false),
                        Country_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.City_ID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.Country_ID, cascadeDelete: false)
                .Index(t => t.City_ID)
                .Index(t => t.Country_ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.City_ID, cascadeDelete: true)
                .Index(t => t.City_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Countries", "City_ID", "dbo.Cities");
            DropForeignKey("dbo.Employees", "City_ID", "dbo.Cities");
            DropIndex("dbo.Employees", new[] { "Country_ID" });
            DropIndex("dbo.Countries", new[] { "City_ID" });
            DropIndex("dbo.Employees", new[] { "City_ID" });
            DropTable("dbo.Countries");
            DropTable("dbo.Employees");
            DropTable("dbo.Cities");
        }
    }
}
