using Anitube.API.ViewModels.VoiceoverActorViewModel;
using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.VoiceoverActorDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Anitube.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoiceoverActorController : ControllerBase
    {
        private readonly IVoiceoverActorApplication _voiceoverActorApplication;
        private readonly IMapper _mapper;

        public VoiceoverActorController(IVoiceoverActorApplication voiceoverActorApplication, IMapper mapper)
        {
            _voiceoverActorApplication = voiceoverActorApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<VoiceoverActorViewModel>> GetGenres()
        {
            return _mapper.Map<List<VoiceoverActorViewModel>>(await _voiceoverActorApplication.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<VoiceoverActorViewModel> GetGenre(int id)
        {
            return _mapper.Map<VoiceoverActorViewModel>(await _voiceoverActorApplication.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task PostGenre([FromBody] CreateVoiceoverActorViewModel genre)
        {
            await _voiceoverActorApplication.AddAsync(_mapper.Map<CreateVoiceoverActorDTO>(genre));
        }

        [HttpPut]
        public async Task PutGenre([FromBody] VoiceoverActorViewModel genre)
        {
            await _voiceoverActorApplication.UpdateAsync(_mapper.Map<VoiceoverActorDTO>(genre));
        }

        [HttpDelete]
        public async Task DeleteGenre([FromBody] VoiceoverActorViewModel genre)
        {
            await _voiceoverActorApplication.DeleteAsync(_mapper.Map<VoiceoverActorDTO>(genre));
        }
    }
}
