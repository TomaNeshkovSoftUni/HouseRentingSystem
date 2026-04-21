namespace HouseRentingSystem.App.Middlewares
{
    public static class TimeMeasurementMiddlewareExtensions
    {
        public static IApplicationBuilder UseTimeMeasurement(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeMeasurementMiddleware>();
        }
    }
}
