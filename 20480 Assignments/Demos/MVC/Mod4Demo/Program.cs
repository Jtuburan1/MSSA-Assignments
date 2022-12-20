using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Route 1 ... convention based (more specific)
app.MapControllerRoute(
    name: "first",
    pattern: "{action}/{param?}",
    defaults: new { controller = "Home", action = "Index" }
    //constraints: new { param = "[0-9]+" }
    );

//Route 2 ... more generalized
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Other}/{action=Index}/{id?}"
    );

app.Run();
