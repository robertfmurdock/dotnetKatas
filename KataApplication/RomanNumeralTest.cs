using System;

using NUnit.Framework;

namespace KataApplication
{
    [TestFixture]
    public class RomanNumeralConverterTest
    {

        [Test]
        public void ShouldReturn1ForI()
        {
            var actualResult = RomanNumeralConverter.Convert("I");
            var expectedResult = 1;
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}