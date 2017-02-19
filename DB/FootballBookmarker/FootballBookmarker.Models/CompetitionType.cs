using System.Collections.Generic;

namespace FootballBookmarker.Models
{
    public class CompetitionType
    {
        private ICollection<Competition> competitions;

        public CompetitionType()
        {
            this.competitions = new HashSet<Competition>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Competition> Competitions
        {
            get { return this.competitions; }
            set { this.competitions = value; }
        }
    }
}
