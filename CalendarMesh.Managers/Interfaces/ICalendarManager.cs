using System;
using CalendarMesh.DomainObjects;

namespace CalendarMesh.Managers.Interfaces
{
    public interface ICalendarManager : IDisposable
    {
        User GetUser(int id);
    }
}