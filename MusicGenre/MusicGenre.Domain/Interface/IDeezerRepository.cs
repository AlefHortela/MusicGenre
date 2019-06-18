using MusicGenre.Domain.Enum;
using MusicGenre.Domain.Model.DeezerModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenre.Domain.Interface
{
    public interface IDeezerRepository : IDisposable
    {
        Task<long> GetPlaylistIdByGenreAsync(GenreTypes genre);
        Task<List<DeezerTrack>> GetTracksByPlaylistIdAsync(long idPlaylist);
    }
}
