using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mascotas.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MascotasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MascotasContext") ?? throw new InvalidOperationException("Connection string 'MascotasContext' not found.")));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Mascotas}/{action=Index}/{id?}");

app.Run();
