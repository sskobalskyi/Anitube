namespace Anitube.Core.Entities
{
    public class Episode
    {
        public int Id { get; set; }
        public int AnimeId { get; set; }
        public Anime? Anime { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
    }
}