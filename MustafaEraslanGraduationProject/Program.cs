using Microsoft.EntityFrameworkCore;
using MustafaEraslanGraduationProject;
using MustafaEraslanGraduationProject.Service;
using MustafaEraslanGraduationProject.Service.Imp;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MoviesContext>(

    o => o.UseNpgsql(builder.Configuration.GetConnectionString("default"), o =>
    {
        o.MigrationsAssembly(Assembly.GetAssembly(typeof(MoviesContext)).GetName().Name);
    }));
builder.Services.AddScoped<IGenreService, GenresService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<ITrendingService, TrendingService>();
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
