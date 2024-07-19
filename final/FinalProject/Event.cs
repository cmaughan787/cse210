public class Event : Add
{
    private Date _startDate; 
    private Date _endDate;
    public int _eventID;

    public Event(string title, string description, Date date, Date startDate, Date endDate, int eventID) 
        : base(title, description, date)
    {
        _startDate = startDate;
        _endDate = endDate;
        _eventID = eventID;
    }

        public override void Create(Calendar calendar)
    {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Start Date (yyyy-MM-dd): ");
        string startDateInput = Console.ReadLine();

        Console.Write("Enter End Date (yyyy-MM-dd): ");
        string endDateInput = Console.ReadLine();

        Console.Write("Enter Event ID: ");
        string eventIDInput = Console.ReadLine();

        if (DateTime.TryParseExact(startDateInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime startParsedDate) &&
            DateTime.TryParseExact(endDateInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime endParsedDate) &&
            int.TryParse(eventIDInput, out int eventID))
        {
            Date startDate = new Date(startParsedDate.Year, startParsedDate.Month, startParsedDate.Day);
            Date endDate = new Date(endParsedDate.Year, endParsedDate.Month, endParsedDate.Day);

            // Update the current Event instance
            _title = title;
            _description = description;
            _startDate = startDate;
            _endDate = endDate;
            _eventID = eventID;

            //Calendar calender = new Calendar();
            Event newEvent = new Event(title, description, startDate, startDate, endDate, eventID);
            // Add the event to the calendar
            calendar.AddEvent(newEvent);

            Console.WriteLine("Event created successfully.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please ensure dates are in yyyy-MM-dd format and Event ID is a number.");
        }
    }

    

    public override void Delete(Calendar calendar)
    {
        Console.Write("Enter Event ID to delete: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int eventID))
    {
        if (input != null)
        {
            Calendar calender = new Calendar();
            calender.RemoveEvent(eventID);
            Console.WriteLine("Event removed from calendar.");
        }
        else
        {
            Console.WriteLine("Event not found in calendar.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
    }

    public override void Display()
    {
        Console.WriteLine("Event Details:");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Start Date: {_startDate.DisplayDate()}");
        Console.WriteLine($"End Date: {_endDate.DisplayDate()}");
        Console.WriteLine($"Event ID: {_eventID}");
    }
}