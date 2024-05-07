namespace Anitube.Core.Entities
{
    public class VoiceoverActor
    {
        public int Id { get; set; }
        public int VoiceoverStudioId { get; set; }
        public required string Nickname { get; set; }
    }
}
