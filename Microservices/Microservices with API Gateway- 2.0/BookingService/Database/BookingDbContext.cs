using Microsoft.EntityFrameworkCore;

namespace BookingService.Database
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(b => b.BookingId);

                entity.Property(b => b.FlightId)
                      .IsRequired();

                entity.Property(b => b.PassengerId)
                      .IsRequired();
            });
        }
    }
}
