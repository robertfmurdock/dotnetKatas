using System;
using NUnit.Framework;

namespace KataApplication.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void ShouldReturn1for1()
        {
            var fizzBuzz = new FizzBuzz();
            var actualReturnValue = fizzBuzz.Process(1);
            String expectedReturnValue = "1";
            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }
    }
}