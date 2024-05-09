using Anitube.API.ViewModels.Profiles;
using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.Profiles;
using Anitube.Application.Applications;
using Anitube.Core.Repositories;
using Anitube.Persistance;
using Anitube.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Anitube.Persistance")
        );
});

builder.Services.AddAutoMapper(typeof(APIProfile).Assembly);
builder.Services.AddAutoMapper(typeof(ApplicationProfile).Assembly);

builder.Services.AddScoped<IAnimeRepository, AnimeRepository>();
builder.Services.AddScoped<IAnimeApplication, AnimeApplication>();

builder.Services.AddScoped<IEpisodeRepository, EpisodeRepository>();
builder.Services.AddScoped<IEpisodeApplication, EpisodeApplication>();

builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IGenreApplication, GenreApplication>();

builder.Services.AddScoped<IVoiceoverActorRepository, VoiceoverActorRepository>();
builder.Services.AddScoped<IVoiceoverActorApplication, VoiceoverActorApplication>();

builder.Services.AddScoped<IVoiceoverStudioRepository, VoiceoverStudioRepository>();
builder.Services.AddScoped<IVoiceoverStudioApplication, VoiceoverStudioApplication>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserApplication, UserApplication>();

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
