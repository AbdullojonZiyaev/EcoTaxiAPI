using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using EcoTaxiAPI.Exceptions;

namespace EcoTaxiAPI.Middleware
{
    public class ExceptionMiddleware(RequestDelegate _next, ILogger<ExceptionMiddleware> _logger)
    {
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            int statusCode;
            string errorCode;
            string errorMessage;

            switch (exception)
            {
                case ToException toException:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    errorCode = toException.Message;
                    errorMessage = toException.Message; // Or a user-friendly message if available
                    break;
                case KeyNotFoundException:
                    statusCode = (int)HttpStatusCode.NotFound;
                    errorCode = ToErrors.ANKETA_NOT_FOUND;
                    errorMessage = "The requested resource was not found.";
                    break;
                default:
                    statusCode = (int)HttpStatusCode.InternalServerError;
                    errorCode = ToErrors.OPERATION_FAILED;
                    errorMessage = "Internal Server Error. An unexpected error occurred.";
                    break;
            }

            context.Response.StatusCode = statusCode;

            var response = new
            {
                StatusCode = statusCode,
                Message = errorMessage,
                ErrorCode = errorCode,
                Detailed = exception.Message // Optional: Include detailed message in development environment only
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
