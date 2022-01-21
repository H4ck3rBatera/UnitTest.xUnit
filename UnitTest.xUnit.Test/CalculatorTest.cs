using System;
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
        public void AddHappy()
        {
            const int expected = 2;
            var actual = _calculator.Sum(1, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddSad()
        {
            const int expected = 3;
            var actual = _calculator.Sum(1, 1);

            Assert.NotEqual(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(5, 5, 10)]
        [InlineData(10, 10, 20)]
        public void AddHappyMultiple(int x, int y, int expected)
        {
            var actual = _calculator.Sum(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, 1)]
        [InlineData(5, null)]
        public void AddExceptionMultiple(int? x, int? y)
        {
            Assert.Throws<ArgumentNullException>(() => _calculator.Sum(x, y));
        }
    }
}