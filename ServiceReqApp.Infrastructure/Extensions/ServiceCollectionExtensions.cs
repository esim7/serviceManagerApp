using Microsoft.Extensions.DependencyInjection;
using ServiceReqApp.Domain;
using ServiceReqApp.Infrastructure.Implementations;
using ServiceReqApp.Infrastructure.Interfaces;

namespace ServiceReqApp.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Customer>, CustomersRepository>();
            services.AddScoped<IRepository<Employee>, EmployesRepository>();
            services.AddScoped<IRepository<Request>, RequestsRepository>();
            services.AddScoped<IRepository<UserProfile>, UserProfilesRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}