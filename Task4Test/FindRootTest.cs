using System;
using NUnit.Framework;
using static Task4.FindRoot;

namespace Task4Test
{
    [TestFixture]
    public class FindRootTest
    {
        [TestCase(8, -15, 0)]
        [TestCase(8, -1, 0)]
        [TestCase(8, -144, 0)]
        public void Find_ThrowArgumentException(double x, int power, double e)
        {
            Assert.Throws<ArgumentException>(() => Find(x, power, e));
        }

        [TestCase(144, 2, 0.0001, ExpectedResult = 12)]
        [TestCase(2.25, 2, 0.1, ExpectedResult = 1.50125)]
        [TestCase(double.MaxValue, Int16.MaxValue, 0.001, ExpectedResult = 32.765010813801666d)]
        public double FindMaster_PositivTest(double x, int power, double e)
        {
            return Find(x, power, e);
        } 



    }
}
