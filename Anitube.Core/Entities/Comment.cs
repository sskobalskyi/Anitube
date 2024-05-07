namespace Anitube.Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int AnimeId { get; set; }
        public Anime? Anime { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}