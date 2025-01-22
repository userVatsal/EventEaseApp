using System.Collections.Generic;

namespace EventEaseApp.Data
{
    public class EventService
    {
        private List<Event> events = new List<Event>();

        public void AddEvent(Event event)
        {
            events.Add(event);
        }

        public List<Event> GetEvents()
        {
            return events;
        }
    }

    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}

