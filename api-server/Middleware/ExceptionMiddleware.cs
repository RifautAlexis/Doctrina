using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using api_server.Contract.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Presentation.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        public async Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            if (exception is ErrorException errorException)
            {
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = errorException.StatusCode;

                var result = JsonConvert.SerializeObject(new ProblemDetails { Status = errorException.StatusCode, Detail = errorException.ErrorMessage, Title = errorException.Title });
                await httpContext.Response.WriteAsync(result);
                return;
            }

            throw exception;
        }
    }

    public static class ExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
