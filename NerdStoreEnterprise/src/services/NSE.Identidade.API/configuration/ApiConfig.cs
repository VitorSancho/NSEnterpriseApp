using Microsoft.AspNetCore.Hosting;

namespace NSE.Identidade.API.configuration
{
    public static class APIconfig
    {
        public static IServiceCollection AddAPIconfiguration(this IServiceCollection services)
        {
            services.AddControllers();

            return services;
        }

        public static IApplicationBuilder UseAPIconfiguration(this IApplicationBuilder app
                                                , IWebHostEnvironment environment)
        {


            // Configure the HTTP request pipeline.
            if (!environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityConfiguration();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
