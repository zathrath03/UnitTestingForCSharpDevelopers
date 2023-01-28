using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }
        
        [Test]
        public void Log_ErrorIsNotNull_SetTheLastErrorProperty()
        {
            const string error = "New Error";
            _logger.Log(error);
            
            Assert.That(_logger.LastError, Is.EqualTo(error));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_ArgumentIsNullOrWhiteSpace_ThrowArgumentNullException(string error)
        {
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
        }
    }
}