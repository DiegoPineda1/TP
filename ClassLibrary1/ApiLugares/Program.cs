using BackCochera.Repository.CarpetaRepositoryFactura.Implementacion;
using BackCochera.Repository.CarpetaRepositoryFactura.Interfaces;
using BackCochera.Repository.CarpetaRepositoryFactura.UnitOfWorkFactura;
using BackCochera.Repository.CarpetaRepositoryLugar.Implementacion;
using BackCochera.Repository.CarpetaRepositoryLugar.Interfaces;
using BackCochera.Repository.CarpetaRepositoryLugar.UnitofWorkLugar;
using BackCochera.Servicios.FacturaServicio;
using BackCochera.Servicios.LugarServicio;
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<db_cocherasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ILugarRepository, LugarRepository>();
builder.Services.AddScoped<IUnitOfWorkLugar, UnitOfWorkLugar>();
builder.Services.AddScoped<ILugarService, LugarService>();
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
