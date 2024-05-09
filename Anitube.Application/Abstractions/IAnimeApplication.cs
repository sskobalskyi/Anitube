using Anitube.Application.DTOs.AnimeDTOs;

namespace Anitube.Application.Abstractions
{
    public interface IAnimeApplication
    {
        Task<List<AnimeLightDTO>> GetAllAsync();
        Task<AnimeLightDTO> GetByIdAsync(int id);
        Task AddAsync(CreateAnimeDTO entity);
        Task UpdateAsync(UpdateAnimeDTO entity);
        Task DeleteAsync(AnimeLightDTO entity);
        Task<AnimeDTO> GetEnrichedAsync(int id);

        Task AddGenreAsync(AddAnimeGenreDTO entity);
        Task AddVoiceoverAsync(AddAnimeVoiceoverDTO entity);
    }
}
