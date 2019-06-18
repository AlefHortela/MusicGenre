using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Domain.Model.DeezerModel
{
    public class DeezerTrack
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("artist")]
        public DeezerArtist Artist { get; set; }
    }
}
