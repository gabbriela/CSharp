using System.Collections.Generic;

namespace Hospital.Models
{
    public class Medicament
    {
        private ICollection<Patient> patients;

        public Medicament()
        {
            this.patients = new HashSet<Patient>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Patient> Patients
        {
            get { return this.patients; }
            set { this.patients = value; }
        }
    }
}
