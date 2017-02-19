namespace MassDefect.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Planet
    {
        private ICollection<Person> persons;

        private ICollection<Anomaly> anomalyFromPlanet;

        private ICollection<Anomaly> anomalyToPlanet;

        public Planet()
        {
            this.persons = new HashSet<Person>();
            this.anomalyFromPlanet = new HashSet<Anomaly>();
            this.anomalyToPlanet = new HashSet<Anomaly>();
        }
        
        public int Id { get; set; }

        public string Name { get; set; }
        
        public virtual Star Sun { get; set; }
        
        [InverseProperty("OriginPlanet")]
        public virtual ICollection<Anomaly> AnomalyFromPlanet
        {
            get { return this.anomalyFromPlanet; }
            set { this.anomalyFromPlanet = value; }
        }

        [InverseProperty("TeleportPlanet")]
        public virtual ICollection<Anomaly> AnomalyToPlanet
        {
            get { return this.anomalyToPlanet; }
            set { this.anomalyToPlanet = value; }
        }
        
        public virtual SolarSystem SolarSystem { get; set; }

        public virtual ICollection<Person> Persons
        {
            get { return this.persons; }
            set { this.persons = value; }
        }
    }
}
