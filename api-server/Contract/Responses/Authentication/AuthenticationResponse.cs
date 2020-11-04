using api_server.Contract.DTOs;

namespace api_server.Contract.Responses
{
    public class AuthenticationResponse
    {
        public Authentication Data { get; set; }
    }

    public class Authentication
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
