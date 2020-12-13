using System.Linq;
using System.Threading.Tasks;
using api_server.Contract.Requests;
using api_server.Data;
using api_server.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using api_server.Contract.Mappers;
using System.Text;
using api_server.Contract.Responses;
using api_server.Contract.Exceptions;

namespace api_server.Handlers
{
    public class SigninHandler : IHandler<SigninRequest, AuthenticationResponse>
    {
        private readonly ApplicationDBContext _appDBContext;
        private readonly IConfiguration _appSettings;

        public SigninHandler(ApplicationDBContext appDBContext, IConfiguration config)
        {
            _appDBContext = appDBContext;
            _appSettings = config;
        }

        public async Task<AuthenticationResponse> Handle(SigninRequest request)
        {

            var (email, password) = request.SigninDTO;

            User user = await _appDBContext.Users.Where(u => u.Email == email).FirstOrDefaultAsync();

            if (user == null) { throw new NotFoundException(); }

            if (!user.VerifyPassword(password)) { throw new InvalidPasswordException(); }

            var secretKey = Encoding.ASCII.GetBytes(_appSettings.GetSection("Settings:Secret").Value);
            var token = user.CreateToken(secretKey);

            await _appDBContext.SaveChangesAsync();

            return new AuthenticationResponse { Data = new Authentication { User = user.ToDTO(), Token = token } };
        }
    }
}
