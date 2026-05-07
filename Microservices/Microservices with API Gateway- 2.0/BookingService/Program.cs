
using BookingService.Database;
using Microsoft.EntityFrameworkCore;

namespace BookingService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionString = builder.Configuration.GetConnectionString("BookingDbConnection");
            builder.Services.AddDbContext<BookingDbContext>(options => options.UseSqlServer(connectionString));


            builder.Services.AddTransient<Services.IBookingService, Services.BookingService>();
            builder.Services.AddTransient<Repository.IBookingRepository, Repository.BookingRepository>();


            builder.Services.AddControllers();

            //auto mapper configuration
            builder.Services.AddAutoMapper(cfg => { }, AppDomain.CurrentDomain.GetAssemblies());


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
