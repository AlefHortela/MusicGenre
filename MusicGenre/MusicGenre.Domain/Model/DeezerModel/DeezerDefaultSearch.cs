using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Domain.Model.DeezerModel
{
    public class DeezerDefaultSearch<T>
    {
        [JsonProperty("data")]
        public List<T> Data { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
    }
}
