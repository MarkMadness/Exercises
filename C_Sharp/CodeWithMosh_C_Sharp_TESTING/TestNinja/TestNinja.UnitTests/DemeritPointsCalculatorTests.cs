using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// Summary description for DemeritPointsCalculatorTests
    /// </summary>
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _dpc;
        [SetUp]
        public void SetUp()
        {
            _dpc = new DemeritPointsCalculator();
        }
        [Test]
        public void CalculateDemeritPoints_SpeedLessThanZero_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _dpc.CalculateDemeritPoints(-1));
        }
        [Test]
        public void CalculateDemeritPoints_SpeedGreaterThan300_ThrowArgumentOutOfRangeException()
        {
            Assert.That(() => _dpc.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(50, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        [TestCase(80, 3)]
        [TestCase(200, 27)]
        public void CalculateDemeritPoints_SpeedGreaterThanSpeedLimit_ReturnDemeritPoint(int speed, int expectedResult)
        {
            var result = _dpc.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
