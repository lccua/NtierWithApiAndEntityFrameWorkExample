using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using SolutionStrips.DATA.Context;
using SolutionStrips.DATA.Repositories;
using SolutionStrips.DOMAIN.Interfaces;
using SolutionStrips.DOMAIN.Services.AuteurService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IAuteurRepository, AuteurRepository>();
builder.Services.AddTransient<IAuteurService, AuteurService>();




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
