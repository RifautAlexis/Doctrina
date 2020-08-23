using System;
namespace api_server.Contract.Exceptions
{
    public class ErrorException : Exception
    {
        public ErrorException(string message) : base(message) { }
    }
}
