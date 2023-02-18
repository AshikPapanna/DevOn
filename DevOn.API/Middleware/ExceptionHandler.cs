namespace DevOn.API.Middleware
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;
        public ExceptionHandler(RequestDelegate next) {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
              await  _next(context);
            }
            catch(Exception e)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Something went wrong");
                //return context;
            }
           // return _next(context);
        } 
    }
}
