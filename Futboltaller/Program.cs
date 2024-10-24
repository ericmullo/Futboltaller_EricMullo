using Futboltaller.Controllers;
using Microsoft.EntityFrameworkCore;
using FutbolTaller.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar el servicio de DbContext y configurar la cadena de conexión a SQL Server
builder.Services.AddDbContext<TallerFutbolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar soporte para controladores con vistas (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar el manejo de excepciones para el entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // Configurar manejo de errores y excepciones para producción
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Usar HTTPS para mayor seguridad
app.UseHttpsRedirection();
app.UseStaticFiles(); // Para habilitar el uso de archivos estáticos como CSS y JavaScript

app.UseRouting(); // Habilitar la creación de rutas para las solicitudes HTTP

// Habilitar la autorización (si usas autenticación, como Identity, lo necesitarás)
app.UseAuthorization();

// Configurar la ruta predeterminada del sistema (controlador y acción)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Ejecutar la aplicación
app.Run();
