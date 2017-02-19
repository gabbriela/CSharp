using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballBookmarker.Models
{
    public class Position
    {
        private ICollection<Player> players;

        public Position()
        {
            this.players = new HashSet<Player>();
        }

        [Key, MinLength(2), MaxLength(2)]
        public string Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }
    }
}
