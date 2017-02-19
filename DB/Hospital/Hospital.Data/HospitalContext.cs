using System.Data.Entity;
using Hospital.Models;

namespace Hospital.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base("HospitalContext")
        {   
        }

        public virtual IDbSet<Patient> Patients { get; set; }
        public virtual IDbSet<Medicament> Medicaments { get; set; }
        public virtual IDbSet<Visitation> Visitations { get; set; }
        public virtual IDbSet<Diagnose> Diagnoses { get; set; }

    }
}
