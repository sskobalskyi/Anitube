namespace Anitube.Core.Entities
{
    public class VoiceoverStudio
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public ICollection<AnimeVoiceover> Animes { get; set; } = new List<AnimeVoiceover>();
        public ICollection<VoiceoverActor> Actors { get; set; } = new List<VoiceoverActor>();
    }
}