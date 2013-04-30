using System;
using System.Linq;
using CalendarMesh.Data.Interfaces;
using CalendarMesh.DomainObjects;
using CalendarMesh.Managers.Interfaces;

namespace CalendarMesh.Managers
{
    public class CalendarManager : ICalendarManager
    {
        private ICalendarRepository m_CalendarRepository;

        public CalendarManager(ICalendarRepository calendarRepository)
        {
            m_CalendarRepository = calendarRepository;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public User GetUser(int id)
        {
            return m_CalendarRepository.GetUsers().FirstOrDefault(a => a.Id == id);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                m_CalendarRepository.Dispose();
                m_CalendarRepository = null;
            }
        }
    }
}