using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Domain.Model.DeezerModel
{
    public class DeezerPlaylist
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("tracks")]
        public List<DeezerTrack> Tracks { get; set; }
    }
}
