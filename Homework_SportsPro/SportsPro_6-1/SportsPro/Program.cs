using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using SportsPro.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<RouteOptions>(opt => opt.LowercaseUrls = true);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SportsProContext>(options => options.UseSqlServer(
                                                builder.Configuration.GetConnectionString("SportsProContext")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
