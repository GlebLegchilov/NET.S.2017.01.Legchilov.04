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
        public double FindMaster_PositivTest(double x, int power, double e)
        {
            return FindMaster(x, power, e);
        } 



    }
}
