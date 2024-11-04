//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        // SetUp and TearDown attributes, NUnit
        private Math _math;
        [SetUp]
        public void SetUp() 
        {
            _math = new Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            //var math = new Math();

            var result = _math.Add(1, 99);

            // Assert.AreEqual(100, result); // MSTest
            Assert.That(result, Is.EqualTo(100)); // NUnit
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstValue()
        {
            var math = new Math();

            var result = math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        [Ignore("I am ignoring this test for now")]
        public void Max_SecondArgumentIsGreater_ReturnSecondValue()
        {
            var math = new Math();

            var result = math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var math = new Math();

            var result = math.Max(3, 3);

            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);

            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered); // Additional check you can do
            Assert.That(result, Is.Unique);  // Additional check you can do
        }
    }
}