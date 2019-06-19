using MusicGenre.Domain.Model.DeezerModel;
using System.Collections.Generic;

namespace MusicGenre.Domain.Interface
{
    public interface IDeezerService
    {
        List<DeezerTrack> GetTracksByTemperature(double temperature);
    }
}
