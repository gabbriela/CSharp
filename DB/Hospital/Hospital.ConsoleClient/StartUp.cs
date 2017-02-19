using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Hospital.Data;
using Hospital.Data.Migrations;
using Hospital.Models;

namespace Hospital.ConsoleClient
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<HospitalContext, Configuration>());

            
            var db = new HospitalContext();

            

            db.SaveChanges();
            using (db)
            {
                Console.WriteLine("For patient: press 1");
                Console.WriteLine("For visitations: press 2");
                Console.WriteLine("For medicine: press 3");
                Console.WriteLine("For diagnose: press 4");

                Console.WriteLine("----------------------------------");

                int commandCode = int.Parse(Console.ReadLine());

                if (commandCode == 1)
                {
                    PatientInteraction(db);
                }
                else if (commandCode == 2)
                {
                    VisitationInteraction(db);
                }
                else if (commandCode == 3)
                {
                    MedicineInteraction(db);
                }
                else
                {
                    DiagnoseInteraction(db);
                }

            }
        }

        private static void DiagnoseInteraction(HospitalContext db)
        {
            Console.WriteLine("Enter new diagnose: press 1");
            Console.WriteLine("Get information about diagnose: press 2");
        }

        private static void MedicineInteraction(HospitalContext db)
        {
            throw new NotImplementedException();
        }

        private static void VisitationInteraction(HospitalContext db)
        {
            throw new NotImplementedException();
        }

        private static void PatientInteraction(HospitalContext db)
        {
            Console.WriteLine("Enter new patient: press 1");
            Console.WriteLine("Get information about patient: press 2");

            int command = int.Parse(Console.ReadLine());

            if (command == 1)
            {
                NewPatient(db);
            }
            else
            {
                GetPatientInfo(db);
            }
        }

        private static void GetPatientInfo(HospitalContext db)
        {
            Console.WriteLine("Enter patient id");

            int patientId = int.Parse(Console.ReadLine());

            var patient = db.Patients
                .FirstOrDefault(p => p.Id == patientId);
            
            Console.WriteLine($"First name:     {patient.FirstName}");
            Console.WriteLine($"Last name:      {patient.LastName}");
            Console.WriteLine($"Address:        {patient.Address}");
            Console.WriteLine($"Date of birth:  {patient.DateOfBirth}");
            Console.WriteLine($"Has insutance:  {patient.HasInsurance}");

            Console.WriteLine("Diagnoses:");
            foreach (var diag in patient.Diagnoses)
            {
                Console.WriteLine($" ------- {diag.Name}");
            }

            Console.WriteLine("Medicaments:");
            foreach (var medicament in patient.Medicaments)
            {
                Console.WriteLine($" ------- {medicament.Name}");
            }

            Console.WriteLine("Visitations:");
            foreach (var visitation in patient.Visitations)
            {
                Console.WriteLine($" ------- {visitation.Date} - {visitation.Comments}");
            }
        }

        private static void NewPatient(HospitalContext db)
        {
            Console.WriteLine("Enter: ");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("");

        }
    }
}
