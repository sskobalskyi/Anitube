using Anitube.Application.Abstractions;
using Anitube.Application.DTOs.UserDTOs;
using Anitube.Core.Entities;
using Anitube.Core.Repositories;
using AutoMapper;

namespace Anitube.Application.Applications
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserApplication(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _repository.GetAllAsync());
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            return _mapper.Map<UserDTO>(await _repository.GetByIdAsync(id));
        }

        public async Task<UserDTO> GetUserByEmailAsync(string email)
        {
            return _mapper.Map<UserDTO>(await _repository.GetUserByEmailAsync(email));
        }

        public async Task<UserDTO> GetUserByUsernameAsync(string username)
        {
            return _mapper.Map<UserDTO>(await _repository.GetUserByUsernameAsync(username));
        }

        public Task CreateUserAsync(CreateUserDTO createUserDTO)
        {
            return _repository.AddAsync(_mapper.Map<User>(createUserDTO));
        }

        public Task UpdateUserAsync(UserDTO user)
        {
            return _repository.UpdateAsync(_mapper.Map<User>(user));
        }

        public Task DeleteUserAsync(UserDTO user)
        {
            return _repository.DeleteAsync(_mapper.Map<User>(user));    
        }
    }
}
