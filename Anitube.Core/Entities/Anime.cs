﻿namespace Anitube.Core.Entities
{
    public class Anime
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
        public ICollection<Episode> Episodes { get; set; } = new List<Episode>();
        public ICollection<AnimeGenre> AnimeGenres { get; set; } = new List<AnimeGenre>();
        public ICollection<AnimeVoiceover> Voiceovers { get; set; } = new List<AnimeVoiceover>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public DateOnly ReleaseDate { get; set; }
    }
}