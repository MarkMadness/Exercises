using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBizzTests
    {
        [Test]
        public void GetOutput_InputIsDivisiblyBy3And5_ReturnFizzBuzz()
        {
            // var fizzBuzz = new FizzBuzz();
            // var result = fizzBuzz.GetOutput(15); // Error: cannot be accessed with an instance reference because the GetOutput method is static

            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisiblyBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutput_InputIsDivisiblyBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(25);

            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void GetOutput_InputIsNotDivisiblyBy3And5_ReturnNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
