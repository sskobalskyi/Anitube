using Anitube.Application.DTOs.EpisodeDTOs;
using Anitube.Application.DTOs.GenreDTOs;

namespace Anitube.Application.DTOs.AnimeDTOs
{
    public class AnimeDTO
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Director { get; set; }
        public required string Studio { get; set; }
        public required double Rating { get; set; }
        public required string ImageUrl { get; set; }
        public required bool IsOnGoing { get; set; }
        public required bool IsVoicedOver { get; set; }
        public required bool IsDubbed { get; set; }
        public required bool IsSubtitled { get; set; }
        public required int TotalEpisodes { get; set; }
        public required int AvailableEpisodes { get; set; }
        public List<EpisodeDTO> Episodes { get; set; } = new List<EpisodeDTO>();
        public List<GenreDTO> Genres { get; set; } = new List<GenreDTO>();
        public DateOnly ReleaseDate { get; set; }
    }
}
