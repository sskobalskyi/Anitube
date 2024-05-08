using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.GenreDTOs;
using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using AutoMapper;

namespace Anitube.Application.UserApplication
{
    public class GenreApplication : IGenreApplication
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreApplication(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task<List<GenreDTO>> GetAllAsync()
        {
            return _mapper.Map<List<GenreDTO>>(await _genreRepository.GetAllAsync());
        }

        public async Task<GenreDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<GenreDTO>(await _genreRepository.GetByIdAsync(id));
        }

        public Task AddAsync(CreateGenreDTO entity)
        {
            return _genreRepository.AddAsync(_mapper.Map<Genre>(entity));
        }

        public Task UpdateAsync(GenreDTO entity)
        {
            return _genreRepository.UpdateAsync(_mapper.Map<Genre>(entity));
        }

        public Task DeleteAsync(GenreDTO entity)
        {
            return _genreRepository.DeleteAsync(_mapper.Map<Genre>(entity));
        }
    }
}
