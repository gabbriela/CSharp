using System.Collections.Generic;

namespace Hospital.Models
{
    public class Diagnose
    {
        private ICollection<Patient> patients;

        public Diagnose()
        {
            this.patients = new HashSet<Patient>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Comments { get; set; }

        
        public virtual ICollection<Patient> Patients
        {
            get { return this.patients; }
            set { this.patients = value; }
        }
    }
}
