using Microsoft.EntityFrameworkCore;
using MontiniMotos.Models;
using MontiniMotos.Services;
using MontiniMotos.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VentasDbContext>(options =>
{
    var config = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(config);
});

builder.Services.AddScoped<ISolicitudPedidoService, SolicitudPedidosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
