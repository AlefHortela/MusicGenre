using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MusicGenre.Application.App;
using MusicGenre.Application.Interface;
using MusicGenre.Domain.Interface;
using MusicGenre.Domain.Service;
using MusicGenre.Infra.Deezer.Repository;
using MusicGenre.Infra.Weather.Repository;

namespace MusicGenre.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASPNET                        
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Repository            
            services.AddScoped<IDeezerRepository, DeezerRepository>();
            services.AddScoped<IWeatherRepository, WeatherRepository>();

            //Services  
            services.AddScoped<IDeezerService, DeezerService>();
            services.AddScoped<IWeatherService, WeatherService>();

            //Application     
            services.AddScoped<IWeatherApp, WeatherApp>();

        }
    }
}
