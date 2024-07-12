
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

    public void AddReminder(Reminder reminder)
    {
        _reminders.Add(reminder);
        Console.WriteLine("Reminder added to calendar");
    }

    // REMOVE 
public void RemoveEvent(int eventID)
{
    Event eventToRemove = _events.FirstOrDefault(e => e._eventID == eventID);
    if (eventToRemove != null)
    {
        _events.Remove(eventToRemove);
        Console.WriteLine("Event removed from calendar.");
    }
    else
    {
        Console.WriteLine("Event not found in calendar.");
    }
}

    // public void RemoveReminder(Reminder reminder)
    // {
    //     _reminders.Remove(reminder);
    //     Console.WriteLine("Reminder added to calendar");
    // }

    public void RemoveReminder(int reminderID)
{
    Reminder reminderToRemove = _reminders.FirstOrDefault(e => e._reminderID == reminderID);
    if (reminderToRemove != null)
    {
        _reminders.Remove(reminderToRemove);
        Console.WriteLine("Reminder removed from calendar.");
    }
    else
    {
        Console.WriteLine("Reminder not found in calendar.");
    }
}
}