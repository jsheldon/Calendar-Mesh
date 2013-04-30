using System;

namespace CalendarMesh.DomainObjects
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Recurring { get; set; }
    }
}