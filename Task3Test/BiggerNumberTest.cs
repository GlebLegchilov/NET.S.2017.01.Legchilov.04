using System;
using NUnit.Framework;
using static Task3.BiggerNumber;

namespace Task3Test
{
    [TestFixture]
    public class BiggerNumberTest
    {
        [TestCase(0)]
        [TestCase(-7)]
        public void NextBiggerNumber_ThrowArgumentException(int number)
        {
            Assert.Throws<ArgumentException>(() => NextBiggerNumber(number));
        }

        [TestCase(13, ExpectedResult = 31)]
        [TestCase(2007, ExpectedResult = 7200)]
        public int NextBiggerNumberMaster_PositiveTest(int number)
        {
            return NextBiggerNumber(number);
        }

    }
}
