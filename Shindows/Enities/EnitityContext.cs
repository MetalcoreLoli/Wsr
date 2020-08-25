namespace Shindows.Enities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EnitityContext : DbContext
    {
        public EnitityContext()
            : base("name=EnitityContext")
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Passport> Passport { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionNameEn> RegionNameEn { get; set; }
        public virtual DbSet<Street> Street { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passport>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Passport)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<Person>()
                .Property(e => e.Photo)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Code)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .HasMany(e => e.RegionNameEn)
                .WithOptional(e => e.Region)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Street>()
                .HasMany(e => e.Address)
                .WithRequired(e => e.Street)
                .WillCascadeOnDelete(false);
        }
    }
}
