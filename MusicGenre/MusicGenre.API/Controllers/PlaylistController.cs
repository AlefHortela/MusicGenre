using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicGenre.Application.Interface;
using MusicGenre.Application.ViewModel;

namespace MusicGenre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IWeatherApp weatherApp;

        public PlaylistController(IWeatherApp _weatherApp)
        {
            weatherApp = _weatherApp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpGet("{city}")]
        public ResultAPIViewModel GetPlaylistByCity(string city)
        {
            return weatherApp.getTracksByCityName(city);
        }
    }
}