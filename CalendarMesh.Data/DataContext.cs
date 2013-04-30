using System.Data.Entity;
using CalendarMesh.DomainObjects;

namespace CalendarMesh.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<User> Users { get; set; }
    }
}