using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.EpisodeDTOs;
using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using AutoMapper;

namespace Anitube.Application.UserApplication
{
    public class EpisodeApplication : IEpisodeApplication
    {
        private readonly IEpisodeRepository _repository;
        private readonly IMapper _mapper;

        public EpisodeApplication(IEpisodeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<EpisodeDTO>> GetAllAsync()
        {
            return _mapper.Map<List<EpisodeDTO>>(await _repository.GetAllAsync());
        }

        public async Task<EpisodeDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<EpisodeDTO>(await _repository.GetByIdAsync(id));
        }

        public Task AddAsync(CreateEpisodeDTO entity)
        {
            return _repository.AddAsync(_mapper.Map<Episode>(entity));
        }
        public Task UpdateAsync(EpisodeDTO entity)
        {
            return _repository.UpdateAsync(_mapper.Map<Episode>(entity));
        }

        public Task DeleteAsync(EpisodeDTO entity)
        {
            return _repository.DeleteAsync(_mapper.Map<Episode>(entity));
        }
    }
}
