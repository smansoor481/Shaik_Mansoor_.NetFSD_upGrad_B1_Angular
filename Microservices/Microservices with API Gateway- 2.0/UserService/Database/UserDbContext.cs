using Microsoft.EntityFrameworkCore;
using UserService.Entity;

namespace UserService.Database
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(u => u.Email)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(u => u.Password)
                      .IsRequired();
            });

            // Seed Data
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Mansoor",
                    Email = "mansoor@gmail.com",
                    Password = "mansoor123",
                  
                },
                new User
                {
                    Id = 2,
                    Name = "Admin User",
                    Email = "admin@gmail.com",
                    Password = "admin123",
                },
                new User
                {
                    Id = 3,
                    Name = "Staff User",
                    Email = "staff@gmail.com",
                    Password = "staff123",
                }
            );

        }
    }
}
