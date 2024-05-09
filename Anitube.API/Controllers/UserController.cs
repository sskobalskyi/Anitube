using Anitube.API.ViewModels.UserViewModels;
using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.UserDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Anitube.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _userApplication;
        private readonly IMapper _mapper;

        public UserController(IUserApplication userApplication, IMapper mapper)
        {
            _userApplication = userApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            return _mapper.Map<List<UserViewModel>>(await _userApplication.GetAllUsersAsync());
        }

        [HttpGet("{id}")]
        public async Task<UserViewModel> GetUserByIdAsync(int id)
        {
            return _mapper.Map<UserViewModel>(await _userApplication.GetUserByIdAsync(id));
        }

        [HttpGet("email/{email}")]
        public async Task<UserViewModel> GetUserByEmailAsync(string email)
        {
            return _mapper.Map<UserViewModel>(await _userApplication.GetUserByEmailAsync(email));
        }

        [HttpGet("username/{username}")]
        public async Task<UserViewModel> GetUserByUsernameAsync(string username)
        {
            return _mapper.Map<UserViewModel>(await _userApplication.GetUserByUsernameAsync(username));
        }

        [HttpPost]
        public async Task CreateUserAsync(CreateUserViewModel user)
        {
            await _userApplication.CreateUserAsync(_mapper.Map<CreateUserDTO>(user));
        }

        [HttpPut]
        public async Task UpdateUserAsync(UserViewModel user)
        {
            await _userApplication.UpdateUserAsync(_mapper.Map<UserDTO>(user));
        }

        [HttpDelete]
        public async Task DeleteUserAsync(UserViewModel user)
        {
            await _userApplication.DeleteUserAsync(_mapper.Map<UserDTO>(user));
        }
    }
}
