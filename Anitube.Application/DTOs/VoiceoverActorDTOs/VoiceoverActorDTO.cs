namespace Anitube.Application.DTOs.VoiceoverActorDTOs
{
    public class VoiceoverActorDTO
    {
        public int Id { get; set; }
        public int VoiceoverStudioId { get; set; }
        public required string Nickname { get; set; }
    }
}
