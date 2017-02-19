﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopSystem.Models
{
    public class Book
    {
        private ICollection<Category> categories;

        public Book()
        {
            this.categories = new HashSet<Category>();
        }

        public int Id { get; set; }

        [MinLength(1), MaxLength(50)]
        public string Title { get; set; }

        [MinLength(0), MaxLength(1000)]
        public string Description { get; set; }

        public EditionType EditionType { get; set; }

        public int Copies { get; set; }

        public DateTime? ReleaseDate { get; set; }
        
        public Author Author { get; set; }

        public ICollection<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }
    }
}
