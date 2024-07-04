public class Holiday : Add
{
    private DateTime _date;

    public Holiday(string title, DateTime date, string description)
        : base(title, description)
    {
        _date = date;
    }

    public void DisplayHoliday()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date.ToString("yyyy-MM-dd HH:mm:ss")}");
        Console.WriteLine($"Description: {_description}");
    }

    public static Holiday AddHoliday()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-MM-dd HH:mm:ss): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm:ss", null);

        return new Holiday(title, date, description);
    }
}