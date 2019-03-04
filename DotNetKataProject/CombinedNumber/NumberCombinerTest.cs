using System;
using KataApplication.CombinedNumber;
using Xunit;

namespace DotNetKataProject.CombinedNumber
{
    public class NumberCombinerTest
    {
        [Fact]
        public void ShouldReturn1For1()
        {
            var combiner = new NumberCombiner();
            var actualReturnValue = combiner.Process(new[] {1});
            String expectedReturnValue = "1";
            Assert.Equal(expectedReturnValue, actualReturnValue);
        }
    }
}