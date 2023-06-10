using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;

namespace WebApp.Utility.Middlewares;

public class TestMiddleware
{
    private readonly RequestDelegate? _next;

    public TestMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, AppDbContext dbContext)
    {
        if (context.Request.Path == "/test")
        {
            await context.Response.WriteAsync(
            $"There are {dbContext.Products?.Count() ?? 0} products\n");
            await context.Response.WriteAsync(
            $"There are {dbContext.Categories?.Count() ?? 0} categories\n");
            await context.Response.WriteAsync(
            $"There are {dbContext.Suppliers?.Count() ?? 0} suppliers\n");
        }
        else
        {
            if (_next is not null)
                await _next(context);
        }
    }
}