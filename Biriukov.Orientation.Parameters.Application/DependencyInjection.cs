using Microsoft.Extensions.DependencyInjection;

namespace Biriukov.Orientation.Parameters.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IEulerAnglesService, EulerAnglesService>();
            return services;
        }
    }
}
