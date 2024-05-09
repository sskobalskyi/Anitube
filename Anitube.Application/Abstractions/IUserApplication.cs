using Anitube.Application.DTOs.UserDTOs;

namespace Anitube.Application.Abstractions
{
    public interface IUserApplication
    {
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<UserDTO> GetUserByEmailAsync(string email);
        Task<UserDTO> GetUserByUsernameAsync(string username);
        Task CreateUserAsync(CreateUserDTO createUserDTO);
        Task UpdateUserAsync(UserDTO user);
        Task DeleteUserAsync(UserDTO user);
    }
}
