using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NSE.Identidade.API.configuration;
using NSE.Identidade.API.data;
using NSE.Identidade.API.extensions;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;
        var configuration = builder.Configuration;

        //configuration.SetBasePath(builder.Environment.ContentRootPath)
        //        .AddJsonFile("appsettings.json",true, true)
        //        .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json",true, true)
        //        .AddEnvironmentVariables();
        
        services.AddIdentityConfiguration(configuration);

        if (builder.Environment.IsDevelopment())
        {
            configuration.AddUserSecrets<StartupBase>();
        }

        // Add services to the container.
        services.AddRazorPages();

        services.AddControllers();

        services.AddAPIconfiguration();

        services.AddSwaggerconfiguration();

        var app = builder.Build();

        app.UseAPIconfiguration(app.Environment);

        app.MapRazorPages();

        app.UseSwaggerconfiguration(app.Environment);

        app.Run();
    }
}