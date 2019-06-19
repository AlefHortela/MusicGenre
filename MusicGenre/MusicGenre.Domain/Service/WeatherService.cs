using MusicGenre.Domain.Interface;
using MusicGenre.Domain.Model.WeatherModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Domain.Service
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository weatherRepository;

        public WeatherService(IWeatherRepository _weatherRepository)
        {
            weatherRepository = _weatherRepository;
        }

        public MainWeather GetCurrentTemperature(string cityName)
        {
            return weatherRepository.GetCurrentTemperatureAsync(cityName).Result;
        }
    }
}
