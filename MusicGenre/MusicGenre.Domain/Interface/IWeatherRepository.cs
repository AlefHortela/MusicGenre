using MusicGenre.Domain.Model.WeatherModel;
using System.Threading.Tasks;

namespace MusicGenre.Domain.Interface
{
    public interface IWeatherRepository
    {
        Task<MainWeather> GetCurrentTemperatureAsync(string cityName);
    }
}
