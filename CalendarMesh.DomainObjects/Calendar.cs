using System.Collections.Generic;

namespace CalendarMesh.DomainObjects
{
    public class Calendar
    {
        public int UserId { get; set; }
        public ICollection<CalendarEvent> Events { get; set; }
    }
}