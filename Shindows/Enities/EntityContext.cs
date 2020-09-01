namespace Shindows.Enities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EngineType> EngineType { get; set; }
        public virtual DbSet<EngineTypeEn> EngineTypeEn { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Licence> Licence { get; set; }
        public virtual DbSet<LicenceStatus> LicenceStatus { get; set; }
        public virtual DbSet<LicenceWithStatus> LicenceWithStatus { get; set; }
        public virtual DbSet<LiceneceHasCategories> LiceneceHasCategories { get; set; }
        public virtual DbSet<Manufaturer> Manufaturer { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Passport> Passport { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionNameEn> RegionNameEn { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<TypeOfDrive> TypeOfDrive { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.LiceneceHasCategories)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Car)
                .WithRequired(e => e.Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Car)
                .WithRequired(e => e.Driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Licence)
                .WithRequired(e => e.Driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EngineType>()
                .HasMany(e => e.EngineTypeEn)
                .WithRequired(e => e.EngineType)
                .HasForeignKey(e => e.EngineTypeRusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EngineType>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.EngineType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Licence>()
                .HasMany(e => e.LicenceWithStatus)
                .WithRequired(e => e.Licence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Licence>()
                .HasMany(e => e.LiceneceHasCategories)
                .WithRequired(e => e.Licence)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LicenceStatus>()
                .HasMany(e => e.LicenceWithStatus)
                .WithRequired(e => e.LicenceStatus)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufaturer>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.Manufaturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Car)
                .WithRequired(e => e.Model)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<TypeOfDrive>()
                .HasMany(e => e.Car)
                .WithRequired(e => e.TypeOfDrive)
                .WillCascadeOnDelete(false);
        }
    }
}
