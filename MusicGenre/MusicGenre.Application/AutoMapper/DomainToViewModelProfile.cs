using AutoMapper;
using MusicGenre.Application.ViewModel;
using MusicGenre.Domain.Model.DeezerModel;
using MusicGenre.Domain.Model.WeatherModel;

namespace MusicGenre.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<DeezerArtist, DeezerArtistViewModel>();
            CreateMap<DeezerTrack, DeezerTrackViewModel>();
            CreateMap<CurrentWeather, CurrentWeatherViewModel>();
            CreateMap<MainWeather, MainWeatherViewModel>();
        }
    }
}
