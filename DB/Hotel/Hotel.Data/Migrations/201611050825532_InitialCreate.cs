namespace Hotel.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BedTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        Notes = c.String(),
                        BedType_Id = c.Int(),
                        RoomStatus_Id = c.Int(),
                        RoomType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BedTypes", t => t.BedType_Id)
                .ForeignKey("dbo.RoomStatus", t => t.RoomStatus_Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomType_Id)
                .Index(t => t.BedType_Id)
                .Index(t => t.RoomStatus_Id)
                .Index(t => t.RoomType_Id);
            
            CreateTable(
                "dbo.RoomStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        EmergencyName = c.String(),
                        EnergencyNumber = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Title = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Occupancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOccupied = c.DateTime(nullable: false),
                        AccountNumber = c.String(),
                        RoomNumber = c.Int(nullable: false),
                        RateApplied = c.Int(nullable: false),
                        PhoneCharge = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentDate = c.DateTime(nullable: false),
                        AccountNumber = c.String(),
                        FirstDateOccupied = c.DateTime(nullable: false),
                        LastDateOccupied = c.DateTime(nullable: false),
                        TotalDays = c.Int(nullable: false),
                        AmountCharged = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxRate = c.Double(nullable: false),
                        TaxAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomType_Id", "dbo.RoomTypes");
            DropForeignKey("dbo.Rooms", "RoomStatus_Id", "dbo.RoomStatus");
            DropForeignKey("dbo.Rooms", "BedType_Id", "dbo.BedTypes");
            DropIndex("dbo.Rooms", new[] { "RoomType_Id" });
            DropIndex("dbo.Rooms", new[] { "RoomStatus_Id" });
            DropIndex("dbo.Rooms", new[] { "BedType_Id" });
            DropTable("dbo.Payments");
            DropTable("dbo.Occupancies");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.RoomStatus");
            DropTable("dbo.Rooms");
            DropTable("dbo.BedTypes");
        }
    }
}
