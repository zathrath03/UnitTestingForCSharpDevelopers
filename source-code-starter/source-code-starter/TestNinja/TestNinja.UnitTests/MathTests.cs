using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            Assert.That(_math.Add(1, 2), Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsFirstArgument()
        {
            Assert.That(_math.Max(2, 1), Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsSecondArgument()
        {
            Assert.That(_math.Max(1, 2), Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnsTheSameArgument()
        {
            var math = new Math();
            Assert.That(math.Max(2, 2), Is.EqualTo(2));
        }
    }
}