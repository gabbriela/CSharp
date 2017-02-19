﻿using System.ComponentModel.DataAnnotations;

namespace FootballBookmarker.Models
{
    public class Town
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public virtual Team Team { get; set; }

        public virtual Country Country { get; set; }
    }
}
