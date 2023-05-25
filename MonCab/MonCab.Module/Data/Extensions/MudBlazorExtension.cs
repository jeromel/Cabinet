using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;

namespace MonCab.Module.Extensions
{
    public static class MudBlazorExtension
    {
        public static void ConfigureMudServices(this IServiceCollection services)
        {
            services.AddMudServices();
            
        }
    }
}