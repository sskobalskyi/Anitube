using Anitube.API.ViewModels.GenreViewModels;
using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.GenreDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Anitube.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreApplication _genreApplication;
        private readonly IMapper _mapper;

        public GenreController(IGenreApplication genreApplication, IMapper mapper)
        {
            _genreApplication = genreApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<GenreViewModel>> GetGenres()
        {
            return _mapper.Map<List<GenreViewModel>>(await _genreApplication.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<GenreViewModel> GetGenre(int id)
        {
            return _mapper.Map<GenreViewModel>(await _genreApplication.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task PostGenre([FromBody] CreateGenreViewModel genre)
        {
            await _genreApplication.AddAsync(_mapper.Map<CreateGenreDTO>(genre));
        }

        [HttpPut]
        public async Task PutGenre([FromBody] GenreViewModel genre)
        {
            await _genreApplication.UpdateAsync(_mapper.Map<GenreDTO>(genre));
        }

        [HttpDelete]
        public async Task DeleteGenre([FromBody] GenreViewModel genre)
        {
            await _genreApplication.DeleteAsync(_mapper.Map<GenreDTO>(genre));
        }
    }
}
