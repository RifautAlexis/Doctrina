using System;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Contract.Responses
{
    public class Response
    {
        public int StatusCode { get; set; }
        public object Result { get; set; }

        public Response(int statusCode, object result)
        {
            StatusCode = statusCode;
            Result = result;
        }
    }
}
