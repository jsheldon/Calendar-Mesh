using System.Linq;
using CalendarMesh.Data.Interfaces;
using CalendarMesh.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalendarMesh.Tests
{
    [TestClass]
    public class CalendarManagerUnitTests
    {
        [TestMethod]
        public void A_valid_user_id_returns_a_valid_user()
        {
            // Arrange
            var r = new Mock<ICalendarRepository>();
            r.Setup(a => a.GetCalendars())
             .Returns(MockData.Calendars.AsQueryable());

            r.Setup(a => a.GetUsers())
             .Returns(MockData.Users.AsQueryable());

            var ds = new CalendarManager(r.Object);
            // Act

            var user = ds.GetUser(1);

            Assert.AreEqual(1, user.Id);
        }

        [TestMethod]
        public void An_Invalid_User_returns_null()
        {
            // Arrange
            var r = new Mock<ICalendarRepository>();
            r.Setup(a => a.GetCalendars())
             .Returns(MockData.Calendars.AsQueryable());

            r.Setup(a => a.GetUsers())
             .Returns(MockData.Users.AsQueryable());

            var ds = new CalendarManager(r.Object);
            
            // Act
            var user = ds.GetUser(11);

            // Assert
            Assert.IsNull(user);
        }

        [TestMethod]
        public void A_Valid_User_With_No_Calendar_Entries_Is_Not_Null()
        {
            // Arrange
            var r = new Mock<ICalendarRepository>();
            r.Setup(a => a.GetCalendars())
             .Returns(MockData.Calendars.AsQueryable());

            r.Setup(a => a.GetUsers())
             .Returns(MockData.Users.AsQueryable());

            var ds = new CalendarManager(r.Object);

            // Act
            var user = ds.GetUser(3);

            // Assert
            Assert.IsNotNull(user.Calendars);
        }

        [TestMethod]
        public void A_Valid_User_With_Calendar_Entries_Returns_Them()
        {
            // Arrange
            var r = new Mock<ICalendarRepository>();
            r.Setup(a => a.GetCalendars())
             .Returns(MockData.Calendars.AsQueryable());

            r.Setup(a => a.GetUsers())
             .Returns(MockData.Users.AsQueryable());

            var ds = new CalendarManager(r.Object);

            // Act
            var user = ds.GetUser(2);

            // Assert
            Assert.IsTrue(user.Calendars.Count > 0);
        }
    }
}