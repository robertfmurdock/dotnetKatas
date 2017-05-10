using System;

using NUnit.Framework;

namespace KataApplication
{
    [TestFixture]
    public class RomanNumeralConverterTest
    {

        [Test]
        public void repeatersCanRepeat_I()
        {
            checkNumeral("I", 1);
            checkNumeral("II", 2);
            checkNumeral("III", 3);
        }

        [Test]
        public void repeatersCanRepeat_X()
        {
            checkNumeral("X", 10);
            checkNumeral("XX", 20);
            checkNumeral("XXX", 30);
        }
        [Test]
        public void repeatersCanRepeat_C()
        {
            checkNumeral("C", 100);
            checkNumeral("CC", 200);
            checkNumeral("CCC", 300);
        }
        [Test]
        public void repeatersCanRepeat_M()
        {
            checkNumeral("M", 1000);
            checkNumeral("MM", 2000);
            checkNumeral("MMM", 3000);
        }

        [Test]
        public void shouldSubtractRepeaterSymbolFromHalfwaySymbol_4ForIV()
        {
            checkNumeral("IV", 4);
        }

        [Test]
        public void shouldSubtractRepeaterSymbolFromRepeaterSymbol_9ForIX()
        {
            checkNumeral("IX", 9);
        }

        [Test]
        public void shouldSubtractRepeaterSymbolFromHalfwaySymbol_40ForXL()
        {
            checkNumeral("XL", 40);
        }

        [Test]
        public void shouldReturn5ForV()
        {
            checkNumeral("V", 5);
        }
        [Test]
        public void shouldReturn50ForL()
        {
            checkNumeral("L", 50);
        }
        [Test]
        public void shouldReturn500ForD()
        {
            checkNumeral("D", 500);
        }

        private void checkNumeral(string stringToConvert, int expectedResult)
        {
            Assert.AreEqual(expectedResult, RomanNumeralConverter.convert(stringToConvert));
        }

    }
}