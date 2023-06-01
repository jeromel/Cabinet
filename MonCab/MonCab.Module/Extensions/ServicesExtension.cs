using Microsoft.Extensions.DependencyInjection;
using MonCab.Module.Services;
using MonCab.Module.Services.PatientService;

namespace MonCab.Module.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<PatientService>();
            services.AddSingleton<MedecinService>();
            
        }
    }
}