namespace Anitube.Core.Entities
{
    public class AnimeGenre
    {
        public int AnimeId { get; set; }
        public Anime? Anime { get; set; }
        public int CategoryId { get; set; }
        public Genre? Category { get; set; }
    }
}