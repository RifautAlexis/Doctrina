using api_server.Contract.DTOs;
using api_server.Data.Models;

namespace api_server.Contract.Mappers
{
    public static class UserMapper
    {

        public static UserDTO ToDTO(this User data)
        {
            if (data == null) return null;

            return new UserDTO
            {
                Id = data.Id,
                Email = data.Email,
                Username = data.Username,
                Role = data.Role
            };
        }
    }
}
