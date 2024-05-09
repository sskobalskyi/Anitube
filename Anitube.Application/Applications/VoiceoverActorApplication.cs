using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.VoiceoverActorDTOs;
using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using AutoMapper;

namespace Anitube.Application.Applications
{
    public class VoiceoverActorApplication : IVoiceoverActorApplication
    {
        private readonly IVoiceoverActorRepository _repository;
        private readonly IMapper _mapper;

        public VoiceoverActorApplication(IVoiceoverActorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public Task AddAsync(CreateVoiceoverActorDTO entity)
        {
            return _repository.AddAsync(_mapper.Map<VoiceoverActor>(entity));
        }

        public Task DeleteAsync(VoiceoverActorDTO entity)
        {
            return _repository.DeleteAsync(_mapper.Map<VoiceoverActor>(entity));
        }

        public async Task<List<VoiceoverActorDTO>> GetAllAsync()
        {
            return _mapper.Map<List<VoiceoverActorDTO>>(await _repository.GetAllAsync());
        }

        public async Task<VoiceoverActorDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<VoiceoverActorDTO>(await  _repository.GetByIdAsync(id));
        }

        public Task UpdateAsync(VoiceoverActorDTO entity)
        {
            return _repository.UpdateAsync(_mapper.Map<VoiceoverActor>(entity));
        }
    }
}
