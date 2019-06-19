using MusicGenre.Domain.Enum;
using MusicGenre.Domain.Interface;
using MusicGenre.Domain.Model.DeezerModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenre.Infra.Deezer.Repository
{
    public class DeezerRepository : IDeezerRepository
    {
        public async Task<long> GetPlaylistIdByGenreAsync(GenreTypes genre)
        {
            var client = new HttpClient();
            var uri = $"https://api.deezer.com/search/playlist?q={genre.ToString()}";

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var playlistString = await response.Content.ReadAsStringAsync();
                var playlists = JsonConvert.DeserializeObject<DeezerPlaylistSearch>(playlistString);
                if (playlists?.Data?.Count > 0)
                    return playlists.Data.FirstOrDefault().Id;
                else
                    return -999L;
            }
            else
            {
                return -999L;
            }
        }

        public async Task<List<DeezerTrack>> GetTracksByPlaylistIdAsync(long idPlaylist)
        {
            var client = new HttpClient();
            var uri = $"https://api.deezer.com/playlist/{idPlaylist}";

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var playlistString = await response.Content.ReadAsStringAsync();
                var playlist = JsonConvert.DeserializeObject<DeezerPlaylist>(playlistString);
                if (playlist?.Tracks?.Count > 0)
                    return playlist.Tracks;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
