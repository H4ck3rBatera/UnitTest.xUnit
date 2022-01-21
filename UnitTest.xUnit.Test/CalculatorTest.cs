using Microsoft.Extensions.DependencyInjection;
using UnitTest.xUnit.Domain;
using Xunit;

namespace UnitTest.xUnit.Test
{
    public class CalculatorTest : IClassFixture<Startup>
    {
        private readonly ICalculator _calculator;

        public CalculatorTest(Startup startup)
        {
            _calculator = startup.ServiceProvider.GetService<ICalculator>();
        }

        [Fact]
        public void Add()
        {
            const int expected = 2;
            var actual = _calculator.Sum(x: 1, y: 1);

            Assert.Equal(expected, actual);
        }
    }
}