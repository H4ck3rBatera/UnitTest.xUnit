# *Project: Unit Test + xUnit + Ioc*

### About xUnit.net
[xUnit](https://xunit.net/ "xUnit")

### Unit Test + IOC
```csharp
public class Startup
    {
        public Startup()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDomain();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; }
    }

public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services
                .AddScoped<ICalculator, Calculator>();

            return services;
        }
    }

public class CalculatorTest : IClassFixture<Startup>
    {
        private readonly ICalculator _calculator;

        public CalculatorTest(Startup startup)
        {
            _calculator = startup.ServiceProvider.GetService<ICalculator>();
        }
    }
```
