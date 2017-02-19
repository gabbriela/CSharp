using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBookmarker.Models
{
    public class Color
    {
        private ICollection<Team> primaryColorTeams;

        private ICollection<Team> secondaryColorTeams;

        public Color()
        {
            this.primaryColorTeams = new HashSet<Team>();
            this.secondaryColorTeams = new HashSet<Team>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        [InverseProperty("PrimaryColor")]
        public virtual ICollection<Team> PrimaryColorTeams
        {
            get { return this.primaryColorTeams; }
            set { this.primaryColorTeams = value; }
        }

        [InverseProperty("SecondaryColor")]
        public virtual ICollection<Team> SecondaryColorTeams
        {
            get { return this.secondaryColorTeams; }
            set { this.secondaryColorTeams = value; }
        }
    }
}
