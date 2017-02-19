using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FootballBookmarker.Models
{
    public class Bet
    {
        private ICollection<BetGame> betGames;

        public Bet()
        {
            this.betGames = new HashSet<BetGame>();
        }

        public int Id { get; set; }

        public decimal BetMoney { get; set; }

        public DateTime BetDate { get; set; }

        public virtual User UserId { get; set; }
        
        public virtual ICollection<BetGame> BetGames
        {
            get { return this.betGames; }
            set { this.betGames = value; }
        }
    }
}
