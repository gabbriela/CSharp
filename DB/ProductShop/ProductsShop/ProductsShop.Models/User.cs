using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace ProductsShop.Models
{
    public class User
    {
        private ICollection<Product> bought;
        private ICollection<Product> sold;
        private ICollection<User> friends;

        public User()
        {
            this.bought = new HashSet<Product>();
            this.sold = new HashSet<Product>();
            this.friends = new HashSet<User>();
        }

        public int Id { get; set; }
        
        public string FirstName { get; set; }

        [Required, MinLength(3)]
        public string LastName { get; set; }

        public int Age { get; set; }

        [InverseProperty("Buyer")]
        public virtual ICollection<Product> Bought
        {
            get { return this.bought; }
            set { this.bought = value; }
            
        }

        [InverseProperty("Seller")]
        public virtual ICollection<Product> Sold
        {
            get { return this.sold; }
            set { this.sold = value; }

        }

        public virtual ICollection<User> Friends
        {
            get { return this.friends; }
            set { this.friends = value; }
        }

    }
}
