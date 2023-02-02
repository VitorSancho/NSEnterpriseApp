using NSE.WebApp.MVC.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration();
builder.Services.AddMvcConfiguration();
builder.Services.RegisterServices();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseMvcConfiguration(app.Environment);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
