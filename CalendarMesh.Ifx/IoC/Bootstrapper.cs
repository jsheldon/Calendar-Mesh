using CalendarMesh.Data;
using CalendarMesh.Data.Interfaces;
using CalendarMesh.Managers;
using CalendarMesh.Managers.Interfaces;
using StructureMap;

namespace CalendarMesh.Ifx.IoC
{
    public static class Bootstrapper
    {
        public static IContainer Init()
        {
            ObjectFactory.Initialize(a =>
                {
                    a.For<DataContext>()
                     .Use(() => new DataContext());

                    a.For<ICalendarRepository>()
                     .Use<CalendarRepository>();

                    a.For<ICalendarManager>()
                     .Singleton()
                     .Use<CalendarManager>();
                });

            return ObjectFactory.Container;
        }
    }
}