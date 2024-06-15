
namespace WebApplication1.Models
{
    public class CustomMiddleware : IMiddleware
    {
        
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)     //next call next middleware
            //pass http ref for next
        {
            await context.Response.WriteAsync("I'm from Middleware");
            await next(context);
        }
    }
}
