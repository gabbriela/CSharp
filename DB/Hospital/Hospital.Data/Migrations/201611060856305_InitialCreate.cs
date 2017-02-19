namespace Hospital.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diagnoses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Picture = c.Binary(),
                        HasInsurance = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visitations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Comments = c.String(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.PatientDiagnoses",
                c => new
                    {
                        Patient_Id = c.Int(nullable: false),
                        Diagnose_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Patient_Id, t.Diagnose_Id })
                .ForeignKey("dbo.Patients", t => t.Patient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Diagnoses", t => t.Diagnose_Id, cascadeDelete: true)
                .Index(t => t.Patient_Id)
                .Index(t => t.Diagnose_Id);
            
            CreateTable(
                "dbo.MedicamentPatients",
                c => new
                    {
                        Medicament_Id = c.Int(nullable: false),
                        Patient_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Medicament_Id, t.Patient_Id })
                .ForeignKey("dbo.Medicaments", t => t.Medicament_Id, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Patient_Id, cascadeDelete: true)
                .Index(t => t.Medicament_Id)
                .Index(t => t.Patient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitations", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.MedicamentPatients", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.MedicamentPatients", "Medicament_Id", "dbo.Medicaments");
            DropForeignKey("dbo.PatientDiagnoses", "Diagnose_Id", "dbo.Diagnoses");
            DropForeignKey("dbo.PatientDiagnoses", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.MedicamentPatients", new[] { "Patient_Id" });
            DropIndex("dbo.MedicamentPatients", new[] { "Medicament_Id" });
            DropIndex("dbo.PatientDiagnoses", new[] { "Diagnose_Id" });
            DropIndex("dbo.PatientDiagnoses", new[] { "Patient_Id" });
            DropIndex("dbo.Visitations", new[] { "PatientId" });
            DropTable("dbo.MedicamentPatients");
            DropTable("dbo.PatientDiagnoses");
            DropTable("dbo.Visitations");
            DropTable("dbo.Medicaments");
            DropTable("dbo.Patients");
            DropTable("dbo.Diagnoses");
        }
    }
}
