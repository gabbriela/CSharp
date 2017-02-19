namespace Hospital.Models
{
    using System;

    public class Visitation
    {
        public Visitation()
        {
            Date = new DateTime(2016,01,01);
        }
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}
