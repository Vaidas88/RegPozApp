using Microsoft.EntityFrameworkCore;
using RegPozApp.Models;

namespace RegPozApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feature>().HasData(
                new Feature()
                {
                    Id = 1,
                    Name = "Reikia atlikti rangos darbus",
                    IsDeleted = false
                },
                new Feature()
                {
                    Id = 2,
                    Name = "Rangos darbus atliks",
                    IsDeleted = false
                },
                new Feature()
                {
                    Id = 3,
                    Name = "Verslo klientas",
                    IsDeleted = false
                },
                new Feature()
                {
                    Id = 4,
                    Name = "Skaičiavimo metodas",
                    IsDeleted = false
                },
                new Feature()
                {
                    Id = 5,
                    Name = "Svarbus klientas",
                    IsDeleted = false
                }
            );

            modelBuilder.Entity<Value>().HasData(
                new Value()
                {
                    Id = 1,
                    Name = "Taip",
                    FeatureId = 1,
                    Current = true,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 2,
                    Name = "Ne",
                    FeatureId = 1,
                    Current = false,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 3,
                    Name = "Metinis rangovas",
                    FeatureId = 2,
                    Current = true,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 4,
                    Name = "Metinis subrangovas",
                    FeatureId = 2,
                    Current = false,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 5,
                    Name = "Senas rangovas",
                    FeatureId = 2,
                    Current = false,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 6,
                    Name = "Naujas rangovas",
                    FeatureId = 2,
                    Current = false,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 7,
                    Name = "Taip",
                    FeatureId = 3,
                    Current = false,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 8,
                    Name = "Ne",
                    FeatureId = 3,
                    Current = true,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 9,
                    Name = "Automatinis",
                    FeatureId = 4,
                    Current = true,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 10,
                    Name = "Rankinis",
                    FeatureId = 4,
                    Current = false,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 11,
                    Name = "Taip",
                    FeatureId = 5,
                    Current = false,
                    IsDeleted = false
                },
                new Value()
                {
                    Id = 12,
                    Name = "Ne",
                    FeatureId = 5,
                    Current = false,
                    IsDeleted = false
                }
            );
        }
    }
}
