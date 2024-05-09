using Anitube.Application.DTOs.AnimeDTOs;
using Anitube.Application.DTOs.EpisodeDTOs;
using Anitube.Application.DTOs.GenreDTOs;
using Anitube.Application.DTOs.UserDTOs;
using Anitube.Application.DTOs.VoiceoverActorDTOs;
using Anitube.Application.DTOs.VoiceoverStudioDTOs;
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
                .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.AnimeGenres))
                .ForMember(dest => dest.Voiceovers, opt => opt.MapFrom(src => src.Voiceovers));
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

            #region AnimeVoiceover
            CreateMap<AddAnimeVoiceoverDTO, AnimeVoiceover>().ReverseMap();
            CreateMap<AnimeVoiceover, VoiceoverStudioDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Studio.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Studio.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Studio.Description));
            #endregion

            #region Episode
            CreateMap<EpisodeDTO, Episode>().ReverseMap();
            CreateMap<CreateEpisodeDTO, Episode>().ReverseMap();
            #endregion

            #region Genre
            CreateMap<GenreDTO, Genre>().ReverseMap();
            CreateMap<CreateGenreDTO, Genre>().ReverseMap();
            #endregion

            #region VoiceoverStudio
            CreateMap<VoiceoverStudioDTO, VoiceoverStudio>().ReverseMap();
            CreateMap<CreateVoiceoverStudioDTO, VoiceoverStudio>().ReverseMap();
            #endregion

            #region VoiceoverActor
            CreateMap<VoiceoverActorDTO, VoiceoverActor>().ReverseMap();
            CreateMap<CreateVoiceoverActorDTO, VoiceoverActor>().ReverseMap();
            #endregion

            #region User
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<CreateUserDTO, User>().ReverseMap();
            #endregion
        }
    }
}
