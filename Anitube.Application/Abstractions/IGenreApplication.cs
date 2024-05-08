using Anitube.Application.DTOs.GenreDTOs;

namespace Anitube.Application.Abstractions
{
    public interface IGenreApplication
    {
        Task<List<GenreDTO>> GetAllAsync();
        Task<GenreDTO> GetByIdAsync(int id);
        Task AddAsync(CreateGenreDTO entity);
        Task UpdateAsync(GenreDTO entity);
        Task DeleteAsync(GenreDTO entity);
    }
}
