using Microsoft.EntityFrameworkCore;
using PassengerService.Entity;
using System.Data;

namespace PassengerService.Database
{
    public class PassengerDbContext : DbContext
    {
        public PassengerDbContext(DbContextOptions<PassengerDbContext> options) : base(options) { }


        public DbSet<Passenger> Passenger { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Age).IsRequired().HasMaxLength(100);
            });


            //seed data
            modelBuilder.Entity<Passenger>().HasData(
                    new Passenger { Id = 1, Name = "Mansoor", Age = 23 },
                    new Passenger { Id = 2, Name = "Munaf", Age = 23 }
                );
        }
    }
}
