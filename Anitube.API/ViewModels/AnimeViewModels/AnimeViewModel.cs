﻿using Anitube.API.ViewModels.Episode;

namespace Anitube.API.ViewModels.Anime
{
    public class AnimeViewModel
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
        public List<EpisodeViewModel> Episodes { get; set; } = new List<EpisodeViewModel>();
        public DateOnly ReleaseDate { get; set; }
    }
}
