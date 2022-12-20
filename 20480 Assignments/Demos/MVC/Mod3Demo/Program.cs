using Microsoft.Extensions.FileProviders;
using Mod3Demo.Services;

// Configure Services Area
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRandom, RandomService>(); // Transient = many instances of object creation, Singleton = 1 object used in multiple pages, Scoped = is page specific but will be constant within each page opened but change when page is refreshed
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
// it will search for Default.html in wwwroot
DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("Home.html");
app.UseDefaultFiles(defaultFilesOptions);
app.UseStaticFiles(); // Middleware 1 able to serve all static files from wwwroot

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Staticfiles")), RequestPath = "/Static"
});

// Custom Middleware
app.Use(async (context, next) =>
{
    //detection of culture/language
    //custom logic
    await next();
});

app.UseRouting(); // Middleware 2

app.UseAuthorization(); // Middleware 3

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
