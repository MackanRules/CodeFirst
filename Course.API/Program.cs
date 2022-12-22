using AutoMapper;
using Comp.Common.DTOs;
using Comp.Database.Interfaces;
using Comp.Database.Services;
using Course.Common.DTOs;
using Course.Database.Contexts;
using Course.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PersonContext>(
 options =>
 options.UseSqlServer(
 builder.Configuration.GetConnectionString("CompanyConnection")));

ConfigureServices(builder.Services);
ConfigureAutoMapper(builder.Services);

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

void ConfigureAutoMapper(IServiceCollection services)
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Company, CompanyDTO>().ReverseMap();
        cfg.CreateMap<Department, DepartmentDTO>().ReverseMap();
        cfg.CreateMap<Person, PersonDTO>().ReverseMap();
        cfg.CreateMap<Position, PositionsDTO>().ReverseMap();
        cfg.CreateMap<PersonPosition, PersonPositionDTO>().ReverseMap();
    });
    var mapper = config.CreateMapper();
    services.TryAddSingleton(mapper);
}

void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IDbService, DbService>();
}
