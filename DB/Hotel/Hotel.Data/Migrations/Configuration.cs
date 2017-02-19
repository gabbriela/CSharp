namespace Hotel.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Hotel.Data.HotelContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "Hotel.Data.HotelContext";
        }

        protected override void Seed(Hotel.Data.HotelContext context)
        {
            
        }
    }
}
