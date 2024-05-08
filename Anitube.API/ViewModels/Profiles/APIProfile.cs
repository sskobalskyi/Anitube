using Anitube.API.ViewModels.Anime;
using Anitube.API.ViewModels.AnimeViewModels;
using Anitube.API.ViewModels.Episode;
using Anitube.API.ViewModels.GenreViewModels;
using Anitube.API.ViewModels.VoiceoverActorViewModels;
using Anitube.API.ViewModels.VoiceoverStudioViewModels;
using Anitube.Application.DTOs.AnimeDTOs;
using Anitube.Application.DTOs.EpisodeDTOs;
using Anitube.Application.DTOs.GenreDTOs;
using Anitube.Application.DTOs.VoiceoverActorDTOs;
using Anitube.Application.DTOs.VoiceoverStudioDTOs;
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

            #region AnimeGenre
            CreateMap<AddAnimeGenreViewModel, AddAnimeGenreDTO>().ReverseMap();
            #endregion

            #region AnimeVoiceover
            CreateMap<AddAnimeVoiceoverViewModel, AddAnimeVoiceoverDTO>().ReverseMap();
            #endregion

            #region Episode
            CreateMap<EpisodeViewModel, EpisodeDTO>().ReverseMap();
            CreateMap<CreateEpisodeViewModel, CreateEpisodeDTO>().ReverseMap();
            #endregion

            #region Genre
            CreateMap<GenreViewModel, GenreDTO>().ReverseMap();
            CreateMap<CreateGenreViewModel, CreateGenreDTO>().ReverseMap();
            #endregion

            #region VoiceoverStudio
            CreateMap<VoiceoverStudioViewModel, VoiceoverStudioDTO>().ReverseMap();
            CreateMap<CreateVoiceoverStudioViewModel, CreateVoiceoverStudioDTO>().ReverseMap();
            #endregion

            #region VoiceoverActor
            CreateMap<VoiceoverActorViewModel, VoiceoverActorDTO>().ReverseMap();
            CreateMap<CreateVoiceoverActorViewModel, CreateVoiceoverActorDTO>().ReverseMap();
            #endregion
        }
    }
}
