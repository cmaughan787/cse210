
public class Calendar
{
    private Date _currentDate;
    private List<Event> _events;
    private List<Reminder> _reminders;

    public Calendar()
    {
        _events = new List<Event>();
        _reminders = new List<Reminder>();
    }

public void DisplayCalendar()
    {
        Console.WriteLine("Calendar Overview:");

        // Display Events
        Console.WriteLine("Events:");
        if (_events.Count > 0)
        {
            foreach (var e in _events)
            {
                e.Display();  // Assuming Event class has a Display method
                Console.WriteLine();  // For separation between events
            }
        }
        else
        {
            Console.WriteLine("No events scheduled.");
        }

        // Display Reminders
        Console.WriteLine("Reminders:");
        if (_reminders.Count > 0)
        {
            foreach (var r in _reminders)
            {
                r.Display();  // Assuming Reminder class has a Display method
                Console.WriteLine();  // For separation between reminders
            }
        }
        else
        {
            Console.WriteLine("No reminders set.");
        }
    }

    public void AddEvent(Event eventObj)
    {
        _events.Add(eventObj);
        Console.WriteLine("Event added to calendar.");
    }
}