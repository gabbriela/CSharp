using ProductsShop.Models;

namespace ProductsShop.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductsShopContext : DbContext
    {

        public ProductsShopContext()
            : base("ProductsShopContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<Product> Products { get; set; }
        public virtual IDbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Friends)
                .WithMany();

            base.OnModelCreating(modelBuilder);
        }
    }

}