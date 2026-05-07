
using Microsoft.EntityFrameworkCore;
using PassengerService.Database;

namespace PassengerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionString = builder.Configuration.GetConnectionString("PassengerDbConnection");
            builder.Services.AddDbContext<PassengerDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddTransient<Service.IPassengerService, Service.PassengerService>();
            builder.Services.AddTransient<Repository.IPassengerRepository, Repository.PassengerRepository>();

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
