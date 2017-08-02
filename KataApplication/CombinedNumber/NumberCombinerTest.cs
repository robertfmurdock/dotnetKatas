using System;
using NUnit.Framework;

namespace KataApplication.CombinedNumber
{
    [TestFixture]
    public class NumberCombinerTest
    {
        [Test]
        public void ShouldReturn1for1()
        {
            var combiner = new NumberCombiner();
            var actualReturnValue = combiner.Process(new[] {1});
            String expectedReturnValue = "1";
            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }
    }
}