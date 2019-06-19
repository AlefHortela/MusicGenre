using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGenre.Application.ViewModel
{
    public class ResultAPIViewModel
    {
        public double Temperature { get; set; } 
        public List<DeezerTrackViewModel> Tracks { get; set; }
    }
}
