using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.VoiceoverStudioDTOs;
using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using AutoMapper;

namespace Anitube.Application.Applications
{
    public class VoiceoverStudioApplication : IVoiceoverStudioApplication
    {
        private readonly IVoiceoverStudioRepository _repository;
        private readonly IMapper _mapper;

        public VoiceoverStudioApplication(IVoiceoverStudioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<VoiceoverStudioDTO>> GetAllAsync()
        {
            return _mapper.Map<List<VoiceoverStudioDTO>>(await _repository.GetAllAsync());
        }

        public async Task<VoiceoverStudioDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<VoiceoverStudioDTO>(await _repository.GetByIdAsync(id));
        }

        public Task AddAsync(CreateVoiceoverStudioDTO entity)
        {
            return _repository.AddAsync(_mapper.Map<VoiceoverStudio>(entity));
        }

        public Task UpdateAsync(VoiceoverStudioDTO entity)
        {
            return _repository.UpdateAsync(_mapper.Map<VoiceoverStudio>(entity));
        }

        public Task DeleteAsync(VoiceoverStudioDTO entity)
        {
            return _repository.DeleteAsync(_mapper.Map<VoiceoverStudio>(entity));
        }
    }
}