using AutoMapper;
using MusicGenre.Application.Interface;
using MusicGenre.Application.ViewModel;
using MusicGenre.Domain.Interface;
using System.Collections.Generic;

namespace MusicGenre.Application.App
{
    public class WeatherApp : IWeatherApp
    {
        private readonly IDeezerService deezerService;
        private readonly IWeatherService weatherService;
        private readonly IMapper mapper;

        public WeatherApp(IDeezerService _deezerService, IWeatherService _weatherService, IMapper _mapper)
        {
            deezerService = _deezerService;
            weatherService = _weatherService;
            mapper = _mapper;
        }

        public ResultAPIViewModel getTracksByCityName(string cityName)
        {
            var mainWeather = mapper.Map<MainWeatherViewModel>(weatherService.GetCurrentTemperature(cityName));

            var resultAPI = new ResultAPIViewModel();

            if (mainWeather != null)
            {
                resultAPI.Temperature = mainWeather.MainData.Temperature;
                resultAPI.Tracks = mapper.Map<List<DeezerTrackViewModel>>(deezerService.GetTracksByTemperature(resultAPI.Temperature));
            }

            return resultAPI;

        }
    }
}
