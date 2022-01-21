using Microsoft.Extensions.DependencyInjection;

namespace UnitTest.xUnit.Domain
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services
                .AddScoped<ICalculator, Calculator>();

            return services;
        }
    }
}