namespace MassDefect.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Anomaly
    {
        private ICollection<Person> victims;

        public Anomaly()
        {
            this.victims = new HashSet<Person>();
        }

        public int Id { get; set; }
        
        [InverseProperty("AnomalyFromPlanet")]
        public virtual Planet OriginPlanet { get; set; }

        [InverseProperty("AnomalyToPlanet")]
        public virtual Planet TeleportPlanet { get; set; }
        
        public virtual ICollection<Person> Victims
        {
            get { return this.victims; }
            set { this.victims = value; }
        }
    }
}
