using CourseraBlazor.Models;

namespace CourseraBlazor.Data
{
    public class EventStore
    {
        public List<Event> Events { get; } = new()
        {
            new Event { Id = 1, Name = "Corporate Summit", Date = DateTime.Today.AddDays(10), Location = "London" },
            new Event { Id = 2, Name = "Tech Conference", Date = DateTime.Today.AddDays(20), Location = "Berlin" }
        };

        public void AddEvent(Event newEvent)
        {
            newEvent.Id = Events.Count + 1;
            Events.Add(newEvent);
        }
    }
}
