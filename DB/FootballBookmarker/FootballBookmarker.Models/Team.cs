using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBookmarker.Models
{
    public class Team
    {
        private ICollection<Player> players;
        private ICollection<Game> homeGames;
        private ICollection<Game> awayGames;

        public Team()
        {
            this.players = new HashSet<Player>();
            this.homeGames = new HashSet<Game>();
            this.awayGames = new HashSet<Game>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Logo { get; set; }

        [MinLength(3), MaxLength(3)]
        public string Initials { get; set; }

        public decimal Budget { get; set; }

        [InverseProperty("PrimaryColorTeams")]
        public virtual Color PrimaryColor { get; set; }

        [InverseProperty("SecondaryColorTeams")]
        public virtual Color SecondaryColor { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }

        [InverseProperty("HomeTeam")]
        public virtual ICollection<Game> HomeGames
        {
            get { return this.homeGames; }
            set { this.homeGames = value; }
        }

        [InverseProperty("AwayTeam")]
        public virtual ICollection<Game> AwayGames
        {
            get { return this.awayGames; }
            set { this.awayGames = value; }
        }

    }
}
