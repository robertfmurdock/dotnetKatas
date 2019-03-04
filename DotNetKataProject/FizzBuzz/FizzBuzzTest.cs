using System;
using Xunit;

namespace DotNetKataProject.FizzBuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ShouldReturn1For1()
        {
            var fizzBuzz = new KataApplication.FizzBuzz.FizzBuzz();
            var actualReturnValue = fizzBuzz.Process(1);
            String expectedReturnValue = "1";
            Assert.Equal(expectedReturnValue, actualReturnValue);
        }
    }
}