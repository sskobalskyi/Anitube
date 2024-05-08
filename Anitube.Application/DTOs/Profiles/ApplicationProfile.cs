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
            CreateMap<AnimeDTO, Anime>();
            CreateMap<Anime, AnimeDTO>()
                .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.AnimeGenres));
            CreateMap<AnimeLightDTO, Anime>().ReverseMap();
            CreateMap<CreateAnimeDTO, Anime>().ReverseMap();
            CreateMap<UpdateAnimeDTO, Anime>().ReverseMap();
            #endregion

            #region AnimeGenre
            CreateMap<AddAnimeGenreDTO, AnimeGenre>().ReverseMap();
            CreateMap<AnimeGenre, GenreDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Category.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Category.Description));
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
