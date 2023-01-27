using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationsTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();
            Assert.That(reservation.CanBeCancelledBy(new User { IsAdmin = true }), Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            Assert.IsTrue(reservation.CanBeCancelledBy(user));
        }

        [Test]
        public void CanBeCancelledBy_UserIsNeitherAdminNorMadeBy_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };
            Assert.IsFalse(reservation.CanBeCancelledBy(new User()));
        }
    }
}
