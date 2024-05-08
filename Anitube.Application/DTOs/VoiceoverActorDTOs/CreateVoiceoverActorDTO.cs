namespace Anitube.Application.DTOs.VoiceoverActorDTOs
{
    public class CreateVoiceoverActorDTO
    {
        public int VoiceoverStudioId { get; set; }
        public required string Nickname { get; set; }
    }
}
