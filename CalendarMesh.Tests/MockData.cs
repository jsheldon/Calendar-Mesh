using System;
using System.Collections.Generic;
using System.Linq;
using CalendarMesh.DomainObjects;

namespace CalendarMesh.Tests
{
    internal static class MockData
    {
        static MockData()
        {
            Calendars = new List<Calendar>
                {
                    new Calendar
                        {
                            UserId = 1,
                            Events = new List<CalendarEvent>
                                {
                                    new CalendarEvent {Id = 1, StartDate = DateTime.Parse("1/1/2013")},
                                    new CalendarEvent {Id = 2, StartDate = DateTime.Parse("1/2/2013")},
                                    new CalendarEvent {Id = 3, StartDate = DateTime.Parse("1/3/2013")}
                                }
                        },
                    new Calendar
                        {
                            UserId = 2,
                            Events = new List<CalendarEvent>
                                {
                                    new CalendarEvent {Id = 4, StartDate = DateTime.Parse("2/1/2013")},
                                    new CalendarEvent {Id = 5, StartDate = DateTime.Parse("2/2/2013")},
                                    new CalendarEvent {Id = 6, StartDate = DateTime.Parse("2/3/2013")}
                                }
                        },
                };

            Users = new List<User>
                {
                    new User
                        {
                            Id = 1,
                            RefreshKey = "ABCDEFGHI",
                            Calendars = Calendars.Where(a => a.UserId == 1).ToList()
                        },
                    new User
                        {
                            Id = 2,
                            RefreshKey = "JKLMNOPQR",
                            Calendars = Calendars.Where(a => a.UserId == 2).ToList()
                        },
                    new User
                        {
                            Id = 3,
                            RefreshKey = "OIJASODIJ"
                        }
                };
        }

        public static IList<Calendar> Calendars { get; private set; }
        public static IList<User> Users { get; private set; }
    }
}