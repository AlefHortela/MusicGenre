using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MusicGenre.API.Configurations;
using MusicGenre.Application.Interface;
using MusicGenre.Application.ViewModel;

namespace MusicGenre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IWeatherApp weatherApp;
        private IOptions<AppConfig> settings; 

        public PlaylistController(IWeatherApp _weatherApp, IOptions<AppConfig> _settings)
        {
            weatherApp = _weatherApp;
            settings = _settings;
        }

        /// <summary>
        /// Returns Temperature, tracks and artists based on a City.
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpGet("{city}")]
        public ResultAPIViewModel GetPlaylistByCity(string city)
        {
            return weatherApp.getTracksByCityName(city, settings.Value.WeatherAPIKey);
        }

        /// <summary>
        /// Change the Key of Weather API
        /// </summary>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        [HttpPost]
        public void ChangeAPIKey([FromBody]string ApiKey)
        {
            try
            {
                settings.Value.WeatherAPIKey = ApiKey;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return;
        }
    }
}