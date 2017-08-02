using NUnit.Framework;

namespace KataApplication.RomanNumeralConvertion
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