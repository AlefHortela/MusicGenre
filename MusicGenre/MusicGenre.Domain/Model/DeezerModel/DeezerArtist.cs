using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Domain.Model.DeezerModel
{
    public class DeezerArtist
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
