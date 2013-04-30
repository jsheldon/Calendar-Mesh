using System;
using System.Linq;
using CalendarMesh.Data.Interfaces;
using CalendarMesh.DomainObjects;

namespace CalendarMesh.Data
{
    public class CalendarRepository : ICalendarRepository
    {
        private DataContext m_Context;

        public CalendarRepository(DataContext context)
        {
            m_Context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IQueryable<User> GetUsers()
        {
            return m_Context.Users;
        }

        public IQueryable<Calendar> GetCalendars()
        {
            return m_Context.Calendars;
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                m_Context.Dispose();
                m_Context = null;
            }
        }
    }
}