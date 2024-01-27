using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Metrics;
using static System.Formats.Asn1.AsnWriter;

namespace DataAccess.Context.EntityFramework
{
    public class SimpleContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ABR5RK9\\SQLEXPRESS;Database=WhereAppDb;Integrated Security=true;TrustServerCertificate = True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<EmailParameter> EmailParameters { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StateType> StateTypes { get; set; }
        public DbSet<State> States { get; set; }

        public DbSet<StoreType> StoreTypes { get; set; }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<MeasurementType> MeasurementTypes { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductStore> ProductStores { get; set; }
        public DbSet<UserPerson> UserPersons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData.Seed(modelBuilder);
        }
    }
}
