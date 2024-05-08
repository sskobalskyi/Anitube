using Anitube.API.ViewModels.VoiceoverStudioViewModels;
using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.VoiceoverStudioDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Anitube.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoiceoverStudioController : ControllerBase
    {
        private readonly IVoiceoverStudioApplication _voiceoverStudioApplication;
        private readonly IMapper _mapper;

        public VoiceoverStudioController(IVoiceoverStudioApplication voiceoverStudioApplication, IMapper mapper)
        {
            _voiceoverStudioApplication = voiceoverStudioApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<VoiceoverStudioViewModel>> GetGenres()
        {
            return _mapper.Map<List<VoiceoverStudioViewModel>>(await _voiceoverStudioApplication.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<VoiceoverStudioViewModel> GetGenre(int id)
        {
            return _mapper.Map<VoiceoverStudioViewModel>(await _voiceoverStudioApplication.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task PostGenre([FromBody] CreateVoiceoverStudioViewModel genre)
        {
            await _voiceoverStudioApplication.AddAsync(_mapper.Map<CreateVoiceoverStudioDTO>(genre));
        }

        [HttpPut]
        public async Task PutGenre([FromBody] VoiceoverStudioViewModel genre)
        {
            await _voiceoverStudioApplication.UpdateAsync(_mapper.Map<VoiceoverStudioDTO>(genre));
        }

        [HttpDelete]
        public async Task DeleteGenre([FromBody] VoiceoverStudioViewModel genre)
        {
            await _voiceoverStudioApplication.DeleteAsync(_mapper.Map<VoiceoverStudioDTO>(genre));
        }
    }
}
