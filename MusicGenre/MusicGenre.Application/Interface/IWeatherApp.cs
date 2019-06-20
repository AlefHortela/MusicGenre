using MusicGenre.Application.ViewModel;

namespace MusicGenre.Application.Interface
{
    public interface IWeatherApp
    {
        ResultAPIViewModel getTracksByCityName(string cityName, string apiKey);
    }
}
