using Anitube.Application.DTOs.EpisodeDTOs;

namespace Anitube.Application.Abstractions
{
    public interface IEpisodeApplication
    {
        Task<List<EpisodeDTO>> GetAllAsync();
        Task<EpisodeDTO> GetByIdAsync(int id);
        Task AddAsync(CreateEpisodeDTO entity);
        Task UpdateAsync(EpisodeDTO entity);
        Task DeleteAsync(EpisodeDTO entity);
    }
}
