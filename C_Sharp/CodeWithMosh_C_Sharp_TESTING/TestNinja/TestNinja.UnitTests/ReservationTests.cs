using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUserWhoCreatedReservationIsCanceling_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation{ MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_AnotherUserCancelingReservation_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
