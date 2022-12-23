using EmpManagementSystem.Models;
using EmpManagementSystem.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<ICRUD, CRUDRepository>();
builder.Services.AddScoped<ICRUD, DBCRUD>(); // Added to work with Database
builder.Services.AddScoped<IFileUpload, FileUpload>();
//builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlite("Data Source = CCAD9Employees.db")); //SQL lite db connection
builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer("Server=DESKTOP-6DJ6U5N\\SQLEXPRESS;Database=EmpMngmntDB;Trusted_Connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True")); //Provides connection to your SQL server.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<EmployeeContext>();
    dbContext.Database.EnsureCreated(); // creates the database and checks everytime to ensure a database is there with required context
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
