using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Application.ViewModel
{
    public class DeezerTrackViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DeezerArtistViewModel Artist { get; set; }
    }
}
