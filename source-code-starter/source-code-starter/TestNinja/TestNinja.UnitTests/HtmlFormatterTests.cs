using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_EncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
        }
        
    }
}