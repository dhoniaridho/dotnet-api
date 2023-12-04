using Microsoft.AspNetCore.Mvc;

namespace UIJP
{
    public class ResponsePipe : IActionResult
    {
        public ResponsePipe(System.Net.HttpStatusCode statusCode, string? message, dynamic? data = null)
        {
            StatusCode = statusCode;
            Message = message ?? "Success";
            Data = data ?? new { };
        }

        public System.Net.HttpStatusCode StatusCode { get; }
        public string Message { get; }
        public dynamic Data { get; }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = GetHttpStatusCode();

            var objectResult = new ObjectResult(new
            {
                StatusCode,
                Message,
                Data
            })
            {
                StatusCode = (int)StatusCode
            };

            await objectResult.ExecuteResultAsync(context);
        }

        private int GetHttpStatusCode()
        {
            // You can define your own logic here to map error codes to HTTP status codes
            // For simplicity, we're returning 200 OK for success and 500 Internal Server Error for errors.
            return StatusCode == 0 ? 200 : 500;
        }
    }
}
