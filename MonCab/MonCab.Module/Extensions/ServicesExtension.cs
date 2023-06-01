using Microsoft.Extensions.DependencyInjection;
using MonCab.Module.ConnectedServices.Patients;
using MonCab.Module.Services;
using MonCab.Module.Services.PatientService;

namespace MonCab.Module.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<IPatientService, PatientService>();
            services.AddSingleton<IMedecinService, MedecinService>();
            services.AddSingleton<IPatientsServiceProvider, MockPatientsServiceProvider>();

  }
    }
}