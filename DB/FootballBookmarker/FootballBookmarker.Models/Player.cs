using System.Collections.Generic;

namespace FootballBookmarker.Models
{
    public class Player
    {
        private ICollection<PlayerStatistic> playerStatistics;

        public Player()
        {
            this.playerStatistics = new HashSet<PlayerStatistic>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public bool IsInjured { get; set; }

        public virtual Team Team { get; set; }

        public virtual Position Position { get; set; }

        public virtual ICollection<PlayerStatistic> PlayerStatistics
        {
            get { return this.playerStatistics; }
            set { this.playerStatistics = value; }
        }


    }
}
