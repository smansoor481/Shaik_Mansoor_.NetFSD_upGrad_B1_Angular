using FlightService.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace PassengerService.Database
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options) { }


        public DbSet<Flight> Flight { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.HasKey(f => f.Id);

                entity.Property(f => f.FlightNumber)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(f => f.Source)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(f => f.Destination)
                      .IsRequired()
                      .HasMaxLength(100);
            });

            // Seed data
            modelBuilder.Entity<Flight>().HasData(
                new Flight { Id = 1, FlightNumber = "AI101", Source = "Hyderabad", Destination = "Delhi" },
                new Flight { Id = 2, FlightNumber = "6E202", Source = "Chennai", Destination = "Mumbai" }
            );
        }
    }
}
