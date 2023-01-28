using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_ErrorIsNotNull_SetTheLastErrorProperty()
        {
            const string error = "New Error";
            var log = new ErrorLogger();
            
            log.Log(error);
            
            Assert.That(log.LastError, Is.EqualTo(error));
        }
    }
}