using Anitube.API.ViewModels.Anime;
using Anitube.API.ViewModels.Episode;
using Anitube.Application.DTOs.AnimeDTOs;
using Anitube.Application.DTOs.EpisodeDTOs;
using AutoMapper;

namespace Anitube.API.ViewModels.Profiles
{
    public class APIProfile : Profile
    {
        public APIProfile()
        {
            #region Anime
            CreateMap<AnimeViewModel, AnimeDTO>().ReverseMap();
            CreateMap<AnimeLightViewModel, AnimeLightDTO>().ReverseMap();
            CreateMap<CreateAnimeViewModel, CreateAnimeDTO>().ReverseMap();
            CreateMap<UpdateAnimeViewModel, UpdateAnimeDTO>().ReverseMap();
            #endregion

            #region Episode
            CreateMap<EpisodeViewModel, EpisodeDTO>().ReverseMap();
            CreateMap<CreateEpisodeViewModel, CreateEpisodeDTO>().ReverseMap();
            #endregion
        }
    }
}
