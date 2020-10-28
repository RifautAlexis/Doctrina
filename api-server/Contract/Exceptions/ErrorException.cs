using System;
namespace api_server.Contract.Exceptions
{
    public abstract class ErrorException : Exception
    {
        public abstract string Title { get; }
        public abstract int StatusCode { get; }
        public abstract string ErrorMessage { get; }
    }
}
