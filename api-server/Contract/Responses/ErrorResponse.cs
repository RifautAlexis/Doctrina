using System;
namespace api_server.Contract.Responses
{
    public class ErrorResponse : Response
    {
        public ErrorResponse(object result) : base(400, result) { }
    }
}
