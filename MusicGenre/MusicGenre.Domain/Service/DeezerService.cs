using MusicGenre.Domain.Enum;
using MusicGenre.Domain.Interface;
using MusicGenre.Domain.Model.DeezerModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenre.Domain.Service
{
    public class DeezerService : IDeezerService
    {
        private readonly IDeezerRepository deezerRepository;
        public DeezerService(IDeezerRepository _deezerRepository)
        {
            deezerRepository = _deezerRepository;
        }

        public List<DeezerTrack> GetTracksByTemperature(double temperature)
        {
            GenreTypes genre;
            if (temperature >= 25D)
                genre = GenreTypes.Pop;
            else if (temperature >= 10D)
                genre = GenreTypes.Rock;
            else
                genre = GenreTypes.ClassicMusic;

            var playlistId = deezerRepository.GetPlaylistIdByGenreAsync(genre).Result;

            var playlistTracks = deezerRepository.GetTracksByPlaylistIdAsync(playlistId).Result;

            return playlistTracks;
        }
    }
}
