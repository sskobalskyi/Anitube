using Anitube.API.ViewModels.Anime;
using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.AnimeDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Anitube.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : ControllerBase
    {
        private readonly ILogger<AnimeController> _logger;
        private readonly IAnimeApplication _animeApplication;
        private readonly IMapper _mapper;

        public AnimeController(ILogger<AnimeController> logger, IAnimeApplication animeApplication, IMapper mapper)
        {
            _logger = logger;
            _animeApplication = animeApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<AnimeLightViewModel>> Get()
        {
            return _mapper.Map<List<AnimeLightViewModel>>(await _animeApplication.GetAllAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<AnimeViewModel> Get(int id)
        {
            return _mapper.Map<AnimeViewModel>(await _animeApplication.GetEnrichedAsync(id));
        }

        [HttpPost]
        public async Task Post([FromBody] CreateAnimeViewModel anime)
        {
            await _animeApplication.AddAsync(_mapper.Map<CreateAnimeDTO>(anime));
        }

        [HttpPut]
        public async Task Put([FromBody] UpdateAnimeViewModel anime)
        {
            await _animeApplication.UpdateAsync(_mapper.Map<UpdateAnimeDTO>(anime));
        }

        [HttpDelete]
        public async Task Delete([FromBody] AnimeLightViewModel anime)
        {
            await _animeApplication.DeleteAsync(_mapper.Map<AnimeLightDTO>(anime));
        }
    }
}
