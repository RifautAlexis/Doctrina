using api_server.Contract.DTOs;

namespace api_server.Contract.Responses
{
    public class AuthenticationResponse
    {
        public Autjentication Data { get; set; }
    }

    public class Autjentication
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
