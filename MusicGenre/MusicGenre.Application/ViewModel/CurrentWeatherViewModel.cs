using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Application.ViewModel
{
    public class CurrentWeatherViewModel
    {
        public double Temperature { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaxTemperature { get; set; }
    }
}
