using Biriukov.Orientation.Parameters.Application;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biriukov.Orientation.Parameters.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IEulerAnglesConverter, EulerAnglesConverter>();
            return services;
        }
    }
}
