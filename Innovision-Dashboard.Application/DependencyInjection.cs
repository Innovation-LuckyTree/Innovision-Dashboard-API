using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Innovision_Dashboard.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(opts => opts.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
