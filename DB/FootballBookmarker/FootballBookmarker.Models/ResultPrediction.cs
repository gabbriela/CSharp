using System.Collections.Generic;
using FootballBookmarker.Models.Enumerations;

namespace FootballBookmarker.Models
{
    public class ResultPrediction
    {
        private ICollection<BetGame> betGames;

        public ResultPrediction()
        {
            this.betGames = new HashSet<BetGame>();
        }

        public int Id { get; set; }

        public PredictionValues PredictionValue { get; set; }

        public virtual ICollection<BetGame> BetGames
        {
            get { return this.betGames; }
            set { this.betGames = value; }
        }

        
    }
}
