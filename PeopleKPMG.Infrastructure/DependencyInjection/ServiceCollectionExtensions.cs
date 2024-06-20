using Microsoft.Extensions.DependencyInjection;
using PeopleKPMG.Core.Interfaces;
using PeopleKPMG.Infrastructure.Data;

namespace PeopleKPMG.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            return services;
        }
    }
}