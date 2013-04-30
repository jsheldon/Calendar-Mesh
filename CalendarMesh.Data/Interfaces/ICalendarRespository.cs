using System;
using System.Linq;
using CalendarMesh.DomainObjects;

namespace CalendarMesh.Data.Interfaces
{
    public interface ICalendarRepository : IDisposable
    {
        IQueryable<User> GetUsers();
        IQueryable<Calendar> GetCalendars();
    }
}