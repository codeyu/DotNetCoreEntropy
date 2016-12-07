using Microsoft.Extensions.DependencyInjection;
using src.Services;

namespace src
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            // and a lot more Services
            services.AddTransient<ICountryService, CountryService>();            
            
            
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            return services;
        }
    }
}