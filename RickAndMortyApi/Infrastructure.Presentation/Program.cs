using Core.Contracts.Mapping;
using Core.Services;
using Core.Services.Abstractions;
using Infrastructure.Clients;

namespace Infrastructure.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(AutomapperProfile));

            builder.Services.AddScoped<IHttpClient, RickAndMortyClient>();

            builder.Services.AddScoped<ICharacterService, CharacterService>();
            builder.Services.AddScoped<ILocationService, LocationService>();
            builder.Services.AddScoped<IEpisodeService, EpisodeService>();
            builder.Services.AddScoped<IConverterService, ConverterService>();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}