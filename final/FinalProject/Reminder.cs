public class Reminder : Add
{
    private DateTime _date;

    public Reminder(string title, DateTime date, string description)
        : base(title, description)
    {
        _date = date;
    }

    public void DisplayReminder()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date.ToString("yyyy-MM-dd HH:mm:ss")}");
        Console.WriteLine($"Description: {_description}");
    }

    public static Reminder AddReminder()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-MM-dd HH:mm:ss): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm:ss", null);

        return new Reminder(title, date, description);
    }
}