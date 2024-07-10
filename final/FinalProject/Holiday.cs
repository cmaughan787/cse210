public class Holiday : Add
{
    private DateTime _holidayDate;

    public Holiday(string title, DateTime holidayDate, string description, Date date)
        : base(title, description, date)
    {
        _holidayDate = holidayDate;
    }

    public void DisplayHoliday()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_holidayDate.ToString("yyyy-MM-dd HH:mm:ss")}");
        Console.WriteLine($"Description: {_description}");
    }

    public static Holiday AddHoliday()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-MM-dd HH:mm:ss): ");
        DateTime holidayDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm:ss", null);

        // Create a Date object from holidayDate
        Date date = new Date(holidayDate.Year, holidayDate.Month, holidayDate.Day);

        return new Holiday(title, holidayDate, description, date);
    }
}