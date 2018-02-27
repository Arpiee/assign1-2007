namespace assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Helicopter> Helicopters { get; set; }
        public virtual DbSet<aeroplane> aeroplanes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Helicopter>()
                .Property(e => e.Helicopters)
                .IsUnicode(false);

            modelBuilder.Entity<Helicopter>()
                .Property(e => e.Model_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Helicopter>()
                .Property(e => e.Purpose)
                .IsUnicode(false);

            modelBuilder.Entity<aeroplane>()
                .Property(e => e.planes)
                .IsUnicode(false);

            modelBuilder.Entity<aeroplane>()
                .Property(e => e.company)
                .IsUnicode(false);
        }
    }
}
