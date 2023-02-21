using DevOn.API.Interfaces;
using DevOn.API.Middleware;
using DevOn.API.Services;
using DevOn.Business.Interfaces;
using DevOn.Business.Services;
using DevOn.DB;
using DevOn.DB.Respository;
using DevOn.DB.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;

namespace DevOn.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            

            //Repository
            builder.Services.AddDbContext<DevOnDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IKeyService, KeyServices>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            //  Console.WriteLine(Guid.NewGuid().ToString());
            builder.Services.AddCors(options =>
            {
               options.AddPolicy("AllowAllHeaders",
            builder =>
            {
                builder.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                       .AllowAnyMethod()
                       .AllowCredentials();
            });
            });
            builder.WebHost.UseUrls("http://localhost:4040", "https://localhost:5040");
            var app = builder.Build();


            app.UseMiddleware<ExceptionHandler>();

            CreateDBIfNotExists(app);
           
            // Configure the HTTP request pipeline.
            app.UseCors("AllowAllHeaders");

           
           

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
        public static void CreateDBIfNotExists(WebApplication host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<DevOnDbContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }
    }
}