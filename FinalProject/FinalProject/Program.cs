using DataAccessLibrary.DataAccess;
using DataAccessLibrary.DataAccess.Interface;
using DataAccessLibrary.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FinalProject.Areas.Identity.Data;
using Microsoft.AspNetCore;







var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DBFinalProjectUserContextConnection") ?? throw new InvalidOperationException("Connection string 'DBFinalProjectUserContextConnection' not found.");

// set the connection string for the user identity DB
builder.Services.AddDbContext<DBFinalProjectUserContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<NoheaShopUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<DBFinalProjectUserContext>();

builder.Services.AddDbContext<NoheasApparelContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConString"));


});

// Add services to the container.
builder.Services.AddControllersWithViews();

// lower case the URL
builder.Services.Configure<RouteOptions>(option => option.LowercaseUrls = true);














//add scoped
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

//app.MapControllerRoute(
//            name: "areas",
//            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}/{Slug?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();
app.Run();
