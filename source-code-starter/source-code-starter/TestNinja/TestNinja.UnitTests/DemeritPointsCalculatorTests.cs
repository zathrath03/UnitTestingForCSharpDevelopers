using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(0, 0, TestName = "SpeedLessThanSpeedLimit_Return0")]
        [TestCase(65, 0, TestName = "SpeedEqualsSpeedLimit_Return0")]
        [TestCase(69, 0, TestName = "Speed4OverSpeedLimit_Return0")]
        [TestCase(70, 1, TestName = "Speed5OverSpeedLimit_Return1")]
        [TestCase(74, 1, TestName = "Speed9OverSpeedLimit_Return1")]
        [TestCase(75, 2, TestName = "Speed10OverSpeedLimit_Return2")]
        public void CalculateDemeritPoints_(int speed, int expected)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedLessThan0OrGreaterThanMaxSpeed_ThrowArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints((speed)), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
