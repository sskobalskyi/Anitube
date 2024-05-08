using Anitube.Application.DTOs.VoiceoverStudioDTOs;

namespace Anitube.Application.Abstractions
{
    public interface IVoiceoverStudioApplication
    {
        Task<List<VoiceoverStudioDTO>> GetAllAsync();
        Task<VoiceoverStudioDTO> GetByIdAsync(int id);
        Task AddAsync(CreateVoiceoverStudioDTO entity);
        Task UpdateAsync(VoiceoverStudioDTO entity);
        Task DeleteAsync(VoiceoverStudioDTO entity);
    }
}
