using Microsoft.Extensions.DependencyInjection;
using PeopleKPMG.Application.Interfaces;
using PeopleKPMG.Application.Services;

namespace PeopleKPMG.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            return services;
        }
    }
}