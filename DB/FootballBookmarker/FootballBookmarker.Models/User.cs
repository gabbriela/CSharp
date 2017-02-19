using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FootballBookmarker.Models
{
    public class User
    {
        private ICollection<Bet> bets;

        public User()
        {
            this.bets = new HashSet<Bet>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public decimal Balance { get; set; }

        public virtual ICollection<Bet> Bets
        {
            get { return this.bets; }
            set { this.bets = value; }
        }
    }
}
