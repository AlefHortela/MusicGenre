using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Domain.Model.WeatherModel
{
    public class MainWeather
    {
        [JsonProperty("main")]
        public CurrentWeather MainData { get; set; }
    }
}
