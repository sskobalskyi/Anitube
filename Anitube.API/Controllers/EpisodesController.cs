using Anitube.API.ViewModels.Episode;
using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.EpisodeDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Anitube.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EpisodesController : ControllerBase
    {
        private readonly IEpisodeApplication _episodeApplication;
        private readonly IMapper _mapper;

        public EpisodesController(IEpisodeApplication episodeApplication, IMapper mapper)
        {
            _episodeApplication = episodeApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<EpisodeViewModel>> Get()
        {
            return _mapper.Map<List<EpisodeViewModel>>(await _episodeApplication.GetAllAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<EpisodeViewModel> Get(int id)
        {
            return _mapper.Map<EpisodeViewModel>(await _episodeApplication.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task Post([FromBody] CreateEpisodeViewModel episode)
        {
            await _episodeApplication.AddAsync(_mapper.Map<CreateEpisodeDTO>(episode));
        }

        [HttpPut]
        public async Task Put([FromBody] EpisodeViewModel episode)
        {
            await _episodeApplication.UpdateAsync(_mapper.Map<EpisodeDTO>(episode));
        }

        [HttpDelete]
        public async Task Delete([FromBody] EpisodeViewModel episode)
        {
            await _episodeApplication.DeleteAsync(_mapper.Map<EpisodeDTO>(episode));
        }
    }
}
