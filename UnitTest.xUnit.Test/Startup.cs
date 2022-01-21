using Microsoft.Extensions.DependencyInjection;
using UnitTest.xUnit.Domain;

namespace UnitTest.xUnit.Test
{
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
}