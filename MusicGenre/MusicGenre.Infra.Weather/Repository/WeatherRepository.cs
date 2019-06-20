using MusicGenre.Domain.Interface;
using MusicGenre.Domain.Model.WeatherModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MusicGenre.Infra.Weather.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        public async Task<MainWeather> GetCurrentTemperatureAsync(string cityName, string apiKey)
        {

            var client = new HttpClient();
            var uri = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&appid={apiKey}";

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var currentWeatherString = await response.Content.ReadAsStringAsync();
                var mainWeather = JsonConvert.DeserializeObject<MainWeather>(currentWeatherString);
                if (mainWeather != null)
                    return mainWeather;
                else
                    return null;
            }
            else
            {
                throw new System.Exception(response.ToString());
            }
        }
    }
}
