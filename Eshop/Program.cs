
using Microsoft.OpenApi.Models;

namespace Eshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Eshop REST API v1",
                    Description = "Eshop REST Api for get the product, get list of products and for update the product.",
                    Contact = new OpenApiContact
                    {
                        Name = "GitHub",
                        Url = new Uri("https://github.com/PavelSiemko/eshop_api")
                    }
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options => {
                    options.SwaggerEndpoint("v1/swagger.json", "Eshop API v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
