using AutoMapper;
using MusicGenre.Application.ViewModel;
using MusicGenre.Domain.Model.DeezerModel;

namespace MusicGenre.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<DeezerArtist, DeezerArtistViewModel>();
            CreateMap<DeezerTrack, DeezerTrackViewModel>();
        }
    }
}
