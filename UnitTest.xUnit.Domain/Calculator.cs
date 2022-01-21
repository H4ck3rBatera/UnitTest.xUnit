using System;

namespace UnitTest.xUnit.Domain
{
    public class Calculator : ICalculator
    {
        public int Sum(int? x, int? y)
        {
            if (x == null)
                throw new ArgumentNullException();

            if (y == null)
                throw new ArgumentNullException();

            return x.Value + y.Value;
        }
    }
}