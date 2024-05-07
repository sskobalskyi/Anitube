namespace Anitube.Core.Entities
{
    public class AnimeVoiceover
    {
        public int StudioId { get; set; }
        public VoiceoverStudio? Studio { get; set; }
        public int AnimeId { get; set; }
        public Anime? Anime { get; set; }
    }
}