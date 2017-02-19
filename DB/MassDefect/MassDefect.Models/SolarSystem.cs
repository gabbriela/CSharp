namespace MassDefect.Models
{
    using System.Collections.Generic;

    public class SolarSystem
    {
        private ICollection<Star> stars;

        private ICollection<Planet> planets;

        public SolarSystem()
        {
            this.stars = new HashSet<Star>();
            this.planets = new HashSet<Planet>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Star> Stars
        {
            get { return this.stars; }
            set { this.stars = value; }
        }

        public virtual ICollection<Planet> Planets
        {
            get { return this.planets; }
            set { this.planets = value; }
        }
    }
}
