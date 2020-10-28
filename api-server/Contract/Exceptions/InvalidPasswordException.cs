using System;
namespace api_server.Contract.Exceptions
{
    public class InvalidPasswordException : ErrorException
    {
        public override string Title => "Invalid Password";
        public override int StatusCode => 400;
        public override string ErrorMessage => "Invalid Password";
    }
}
