using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationsTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();
            Assert.IsTrue(reservation.CanBeCancelledBy(new User { IsAdmin = true }));
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            Assert.IsTrue(reservation.CanBeCancelledBy(user));
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNeitherAdminNorMadeBy_ReturnsFalse()
        {
            var reservation = new Reservation() { MadeBy = new User() };
            Assert.IsFalse(reservation.CanBeCancelledBy(new User()));
        }
    }
}
