using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Configurar el DbContext con la cadena de conexi�n 
builder.Services.AddDbContext<TiendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto: se utiliza el controlador "Ventas" y su acci�n "Index"
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ventas}/{action=Index}/{id?}");

app.Run();
