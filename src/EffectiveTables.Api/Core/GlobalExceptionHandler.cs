using System;
using System.Threading.Tasks;
using EffectiveTables.Application.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace EffectiveTables.Api.Core
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.ContentType = "application/json";
                
                object response    = null;
                var statusCode = StatusCodes.Status500InternalServerError;

                switch (ex)
                {
                    case EntityNotFoundException _:
                        statusCode = StatusCodes.Status404NotFound;
                        response = new
                        {
                            message = "Resource not found."
                        };
                        break;
                    default:
                        response = new
                        {
                            message = ex.Message
                        };
                        break;
                }

                httpContext.Response.StatusCode = statusCode;
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
                return;
            }
        }
    }
}