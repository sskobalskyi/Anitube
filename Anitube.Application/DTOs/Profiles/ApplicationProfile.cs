using Anitube.Application.DTOs.AnimeDTOs;
using Anitube.Application.DTOs.EpisodeDTOs;
using Anitube.Application.DTOs.GenreDTOs;
using Anitube.Core.Entities;
using AutoMapper;

namespace Anitube.Application.DTOs.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            #region Anime
            CreateMap<AnimeDTO, Anime>().ReverseMap();
            CreateMap<AnimeLightDTO, Anime>().ReverseMap();
            CreateMap<CreateAnimeDTO, Anime>().ReverseMap();
            CreateMap<UpdateAnimeDTO, Anime>().ReverseMap();
            #endregion

            #region Episode
            CreateMap<EpisodeDTO, Episode>().ReverseMap();
            CreateMap<CreateEpisodeDTO, Episode>().ReverseMap();
            #endregion

            #region Genre
            CreateMap<GenreDTO, Genre>().ReverseMap();
            CreateMap<CreateGenreDTO, Genre>().ReverseMap();
            #endregion
        }
    }
}
