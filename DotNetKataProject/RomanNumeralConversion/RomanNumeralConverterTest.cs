using KataApplication.RomanNumeralConversion;
using Xunit;

namespace DotNetKataProject.RomanNumeralConversion
{
    public class RomanNumeralConverterTest
    {
        [Fact]
        public void ShouldReturn1ForI()
        {
            var actualResult = RomanNumeralConverter.Convert("I");
            const int expectedResult = 1;
            Assert.Equal(expectedResult, actualResult);
        }
    }
}