using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using SolutionStrips.DATA.Context;
using SolutionStrips.DATA.Repositories;
using SolutionStrips.DOMAIN.Interfaces;
using SolutionStrips.DOMAIN.Services.AuteurService;
using SolutionStrips.API.Mappers;
using SolutionStrips.DOMAIN.Services.StripService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddScoped<IAuteurRepository, AuteurRepository>();
builder.Services.AddScoped<IStripRepository, StripRepository>();

// Change the lifetime to scoped
builder.Services.AddScoped<AuteurService>();
builder.Services.AddScoped<StripService>();


builder.Services.AddControllers();


builder.Services.AddAutoMapper(typeof(Program).Assembly);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<SolutionStripsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
