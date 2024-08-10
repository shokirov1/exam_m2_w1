using Task1;

Event @event = new Event();

@event.Name = "9-May";
@event.Title = "Text text";
@event.StartTime = new DateTime(2024, 12, 12);
@event.EndTime = new DateTime(2026, 12, 12);

EventManager eventManager = new EventManager();
eventManager.AddEvent(@event);
eventManager.RemoveEvent("9-Maey");
var s=eventManager.GetFromDate(new DateTime(2024, 12,12));
foreach (var item in s)
{
    Console.WriteLine($"{item.Name} {item.Title} {item.StartTime} {item.EndTime}");
}


