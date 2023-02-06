using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Models;
using ProductManagementSystem.Services;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
//builder.Services.AddSingleton<ITeaRepository,TeaRepository>();
builder.Services.AddScoped<ITeaRepository, DBCRUDTea>();
builder.Services.AddScoped<IFileUpload, FileUpload>();
builder.Services.AddDbContext<TeaContext>(options => options.UseSqlite("Data Source = TeaLounge.DB"));
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
}).AddEntityFrameworkStores<UserContext>();
builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer("Server=DESKTOP-6DJ6U5N\\SQLEXPRESS;Database=TeaLoungeUserDB;Trusted_Connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

using (var scope = app.Services.CreateScope())
{
    var dbTeaContext = scope.ServiceProvider.GetRequiredService<TeaContext>();
    dbTeaContext.Database.EnsureCreated();
    var dbUserContext = scope.ServiceProvider.GetRequiredService<UserContext>();
    dbUserContext.Database.EnsureCreated();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
