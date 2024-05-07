using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.AnimeDTOs;
using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using AutoMapper;

namespace Anitube.Application.UserApplication
{
    public class AnimeApplication : IAnimeApplication
    {
        private readonly IAnimeRepository _repository;
        private readonly IMapper _mapper;

        public AnimeApplication(IAnimeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AnimeLightDTO>> GetAllAsync()
        {
            return _mapper.Map<List<AnimeLightDTO>>(await _repository.GetAllAsync());
        }

        public async Task<AnimeLightDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<AnimeLightDTO>(await _repository.GetByIdAsync(id));
        }

        public async Task<AnimeDTO> GetEnrichedAsync(int id)
        {
            return _mapper.Map<AnimeDTO>(await _repository.GetEnrichedAsync(id));
        }

        public Task AddAsync(CreateAnimeDTO entity)
        {
            return _repository.AddAsync(_mapper.Map<Anime>(entity));
        }

        public Task UpdateAsync(UpdateAnimeDTO entity)
        {
            return _repository.UpdateAsync(_mapper.Map<Anime>(entity));
        }

        public Task DeleteAsync(AnimeLightDTO entity)
        {
            return _repository.DeleteAsync(_mapper.Map<Anime>(entity));
        }
    }
}
