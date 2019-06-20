using MusicGenre.Domain.Model.WeatherModel;

namespace MusicGenre.Domain.Interface
{
    public interface IWeatherService
    {
        MainWeather GetCurrentTemperature(string cityName, string apiKey);
    }
}
