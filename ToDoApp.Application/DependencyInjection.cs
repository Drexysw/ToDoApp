using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            var assembly = typeof(DependencyInjection).Assembly;
            services.AddMediatR(cofiguration =>
                cofiguration.RegisterServicesFromAssembly(assembly));
            services.AddValidatorsFromAssembly(assembly);
            return services;
        }
    }
}
