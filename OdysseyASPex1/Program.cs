using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Ajout des services MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Ajout des middlewares
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();