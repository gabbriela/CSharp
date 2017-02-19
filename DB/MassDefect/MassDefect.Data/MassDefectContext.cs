namespace MassDefect.Data
{
    using System.Data.Entity;
    using Models;

    public class MassDefectContext : DbContext
    {
        public MassDefectContext()
            : base("MassDefectContext")
        {
        }

        public virtual IDbSet<SolarSystem> SolarSystems { get; set; }

        public virtual IDbSet<Star> Stars { get; set; }

        public virtual IDbSet<Planet> Planets { get; set; }

        public virtual IDbSet<Person> Persons { get; set; }

        public virtual IDbSet<Anomaly> Anomalies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // setup AnomalyVictims table
            modelBuilder.Entity<Anomaly>()
               .HasMany<Person>(s => s.Victims)
               .WithMany(c => c.Anomalies)
               .Map(cs =>
               {
                   cs.MapLeftKey("PersonId");
                   cs.MapRightKey("AnomalyId");
                   cs.ToTable("AnomalyVictims");
               });

            // setup explisitly Person table name
            modelBuilder.Entity<Person>()
                .Map(t => t.ToTable("Persons"));
            
            base.OnModelCreating(modelBuilder);
        }
    }
}