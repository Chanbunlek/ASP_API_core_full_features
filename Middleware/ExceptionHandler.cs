using System.Text.Json;
using full_webapi_features.Config;
using full_webapi_features.Utils;
namespace full_webapi_features.Middleware;

public class ExceptionHandler(IHttpContextAccessor accessor) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (ExceptionService ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status200OK;
            await context.Response.WriteAsync(JsonSerializer.Serialize(Response<string>.Failed(ex.Error.Code, accessor.HttpContext?.Request.Path ?? "/error", ex.Error.Message, "")));
        }
    }
}
