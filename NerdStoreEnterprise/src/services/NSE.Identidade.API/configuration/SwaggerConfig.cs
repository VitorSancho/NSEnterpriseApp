using Microsoft.OpenApi.Models;

namespace NSE.Identidade.API.configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerconfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "NerdStore Enterprise Identity API",
                    Description = "Esta API faz parte do curso ASP.NET",
                    Contact = new OpenApiContact() { Name = "Vitor Sancho Cardoso", Email = "vitor.sancho07@gmail.com" }
                    //License = new OpenApiLicense() { Name = "MIT", Url = new Uri("...") }
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerconfiguration(this IApplicationBuilder app
                                                , IWebHostEnvironment environment)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            return app;
        }
    }
}