using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Core.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoreApplication(this IServiceCollection services, Assembly assembly)
        {
            ArgumentNullException.ThrowIfNull(services, nameof(services));

            services.AddMediatR(opt => {
                opt.RegisterServicesFromAssembly(assembly);
            });

            return services;
        }
    }
}
