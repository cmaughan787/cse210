
public class Event : Add
{
    private DateTime _startDate;
    private DateTime _endDate;

    public Event(string title, DateTime startDate, DateTime endDate, string description)
        : base(title, description)
    {
        _startDate = startDate;
        _endDate = endDate;
    }

    public void DisplayEvent()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Start Date: {_startDate.ToString("yyyy-MM-dd HH:mm:ss")}");
        Console.WriteLine($"End Date: {_endDate.ToString("yyyy-MM-dd HH:mm:ss")}");
        Console.WriteLine($"Description: {_description}");
    }

    public static Event AddEvent()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the start date (yyyy-MM-dd HH:mm:ss): ");
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm:ss", null);

        Console.Write("Enter the end date (yyyy-MM-dd HH:mm:ss): ");
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm:ss", null);

        return new Event(title, startDate, endDate, description);
    }
}