using BackCochera.Repository.CarpetaRepositoryAbono.Implementacion;
using BackCochera.Repository.CarpetaRepositoryAbono.Interfaces;
using BackCochera.Repository.CarpetaRepositoryAbono.UnitOfWorkAbono;
using BackCochera.Servicios.AbonoServicio;
using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<db_cocherasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAbonoRepository, AbonoRepository>();
builder.Services.AddScoped<IUnitOfWorkAbono, UnitOfWorkAbono>();
builder.Services.AddScoped<IAbonoServicios, AbonoServicios>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
