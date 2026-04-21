using HouseRentingSystem.Data.Data;
using System.Diagnostics;

namespace HouseRentingSystem.App.Middlewares
{
    public class TimeMeasurementMiddleware
    {
        private RequestDelegate next;

        public TimeMeasurementMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext, HouseRentingSystemDbContext ctx)
        {
           Stopwatch sw = new Stopwatch();
           sw.Start();
           Console.WriteLine("Start");
           await this.next(httpContext);
           sw.Stop();
           Console.WriteLine(sw.ElapsedMilliseconds + " ms");

        }
    }
}
