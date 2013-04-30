using System.Collections.Generic;

namespace CalendarMesh.DomainObjects
{
    public class User
    {
        public User()
        {
            Calendars = new List<Calendar>();
        }

        public int Id { get; set; }
        public ICollection<Calendar> Calendars { get; set; }
        public string RefreshKey { get; set; }
    }
}