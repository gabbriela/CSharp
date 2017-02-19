using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBookmarker.Models
{
    public class Game
    {
        private ICollection<PlayerStatistic> playerStatistics;

        private ICollection<BetGame> betGames;

        public Game()
        {
            this.playerStatistics = new HashSet<PlayerStatistic>();
            this.betGames = new HashSet<BetGame>();
        }

        public int Id { get; set; }

        [InverseProperty("HomeGames")]
        public virtual Team HomeTeam { get; set; }

        [InverseProperty("AwayGames")]
        public virtual Team AwayTeam { get; set; }

        public int HomeGoals { get; set; }

        public int AwayGoals { get; set; }

        public DateTime GameDateTime { get; set; }

        public double HomeTeamWinBetRate { get; set; }

        public double AwayTeamWinBetRate { get; set; }

        public double DrawGameBetRate { get; set; }


        public virtual ICollection<PlayerStatistic> PlayerStatistic
        {
            get { return this.playerStatistics; }
            set { this.playerStatistics = value; }
        }
        
        public virtual ICollection<BetGame> BetGames
        {
            get { return this.betGames; }
            set { this.betGames = value; }
        }

        public virtual Round Round { get; set; }

        public virtual Competition Competition { get; set; }
    }
}
