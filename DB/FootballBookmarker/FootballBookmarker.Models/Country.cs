using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballBookmarker.Models
{
    public class Country
    {
        private ICollection<Town> towns;

        private ICollection<Continent> continents;

        public Country()
        {
            this.towns = new HashSet<Town>();
            this.continents = new HashSet<Continent>();
        }

        [Key, MaxLength(3), MinLength(3)]
        public string Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Town> Towns
        {
            get { return this.towns; }
            set { this.towns = value; }
        }

        public virtual ICollection<Continent> Continents
        {
            get { return this.continents; }
            set { this.continents = value; }
        }

        //Continent
    }
}
