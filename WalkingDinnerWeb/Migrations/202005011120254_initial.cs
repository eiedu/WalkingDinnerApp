namespace WalkingDinnerWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DinnerModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DinnerName = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        PrepTime = c.DateTime(nullable: false),
                        NumOfRounds = c.Int(nullable: false),
                        Parallel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DuoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        FirstNameOne = c.String(nullable: false),
                        LastNameOne = c.String(nullable: false),
                        InsertionOne = c.String(nullable: false),
                        FirstNameTwo = c.String(),
                        LastNameTwo = c.String(),
                        InsertionTwo = c.String(),
                        StreetName = c.String(nullable: false),
                        HouseNumber = c.String(nullable: false),
                        PostalCode = c.String(nullable: false),
                        City = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Dietary = c.String(),
                        DinnerModel_Id = c.Int(),
                        RoundModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DinnerModels", t => t.DinnerModel_Id)
                .ForeignKey("dbo.RoundModels", t => t.RoundModel_Id)
                .Index(t => t.DinnerModel_Id)
                .Index(t => t.RoundModel_Id);
            
            CreateTable(
                "dbo.RoundModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoundName = c.String(nullable: false),
                        RoundNumber = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        DinnerId_Id = c.Int(nullable: false),
                        HostId_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DinnerModels", t => t.DinnerId_Id, cascadeDelete: true)
                .ForeignKey("dbo.DuoModels", t => t.HostId_Id, cascadeDelete: true)
                .Index(t => t.DinnerId_Id)
                .Index(t => t.HostId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DuoModels", "RoundModel_Id", "dbo.RoundModels");
            DropForeignKey("dbo.RoundModels", "HostId_Id", "dbo.DuoModels");
            DropForeignKey("dbo.RoundModels", "DinnerId_Id", "dbo.DinnerModels");
            DropForeignKey("dbo.DuoModels", "DinnerModel_Id", "dbo.DinnerModels");
            DropIndex("dbo.RoundModels", new[] { "HostId_Id" });
            DropIndex("dbo.RoundModels", new[] { "DinnerId_Id" });
            DropIndex("dbo.DuoModels", new[] { "RoundModel_Id" });
            DropIndex("dbo.DuoModels", new[] { "DinnerModel_Id" });
            DropTable("dbo.RoundModels");
            DropTable("dbo.DuoModels");
            DropTable("dbo.DinnerModels");
        }
    }
}
