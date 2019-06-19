using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Domain.Model.WeatherModel
{
    public class CurrentWeather
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
        [JsonProperty("pressure")]
        public double Pressure { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        [JsonProperty("temp_min")]
        public double MinimumTemperature { get; set; }
        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; }
    }
}
