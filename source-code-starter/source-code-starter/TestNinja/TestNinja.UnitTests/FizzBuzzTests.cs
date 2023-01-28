using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(0, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(2, "2")]
        public void GetOutput_WhenCalled_ReturnsCorrectString(int num, string expectedResult)
        {
            Assert.That(FizzBuzz.GetOutput(num), Is.EqualTo(expectedResult));
        }
    }
}