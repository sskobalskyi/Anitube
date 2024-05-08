using Anitube.Application.DTOs.VoiceoverActorDTOs;

namespace Anitube.Application.Abstractions
{
    public interface IVoiceoverActorApplication
    {
        Task<List<VoiceoverActorDTO>> GetAllAsync();
        Task<VoiceoverActorDTO> GetByIdAsync(int id);
        Task AddAsync(CreateVoiceoverActorDTO entity);
        Task UpdateAsync(VoiceoverActorDTO entity);
        Task DeleteAsync(VoiceoverActorDTO entity);
    }
}
