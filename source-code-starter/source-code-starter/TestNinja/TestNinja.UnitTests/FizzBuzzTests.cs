using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(3, "Fizz", TestName = "ArgDivisibleByOnly3_ReturnFizz")]
        [TestCase(5, "Buzz", TestName = "ArgDivisibleByOnly5_ReturnBuzz")]
        [TestCase(15, "FizzBuzz", TestName = "ArgDivisibleBy3And5_ReturnFizzBuzz")]
        [TestCase(1, "1", TestName = "ArgNotDivisibleBy3Or5_ReturnStringOfArg")]
        public void GetOutput(int number, string expectedResult)
        {
            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo(expectedResult));
        }
    }
}