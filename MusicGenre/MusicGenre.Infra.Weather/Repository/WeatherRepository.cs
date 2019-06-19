using MusicGenre.Domain.Interface;
using MusicGenre.Domain.Model.WeatherModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MusicGenre.Infra.Weather.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        private string apiKey = "0a423629a120f69f5ac027bda407ebc2";
        public async Task<MainWeather> GetCurrentTemperatureAsync(string cityName)
        {
            var client = new HttpClient();
            var uri = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

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
                return null;
            }
        }
    }
}
