using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBookmarker.Models
{
    public class BetGame
    {
        [Key]
        [Column(Order = 1)]
        public int GameId { get; set; }

        public virtual Game Game { get; set; }
        
        [Key]
        [Column(Order = 2)]
        public int BetId { get; set; }

        public virtual Bet Bet { get; set; }

        public virtual ResultPrediction ResultPrediction { get; set; }
    }
}
