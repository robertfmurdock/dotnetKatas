using System;
using NUnit.Framework;

[TestFixture]
public class FizzBuzzTest
{
    [Test]
    public void shouldReturn1for1()
    {
        var fizzBuzz = new FizzBuzz();
        var actualReturnValue = fizzBuzz.process(1);
        String expectedReturnValue = "1";
        Assert.AreEqual(expectedReturnValue, actualReturnValue);
    }
}