public class Reminder : Add
{
    // private int _reminderID;

    public Reminder(string title, string description, Date date)
        : base(title, description, date)
    {
      //  _reminderID = reminderID;
    }

    public void Create()
    {
        Console.Write("Name Reminder: ");
        string title = Console.ReadLine();

        Console.Write("Write description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-MM-dd): ");
        string dateInput = Console.ReadLine();

        if (DateTime.TryParseExact(dateInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
            Date date = new Date(parsedDate.Year, parsedDate.Month, parsedDate.Day);

            // Assign the values to the current Reminder instance
            _title = title;
            _description = description;
            _date = date;

            Console.WriteLine("Reminder created successfully.");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
        }
    }

    public void Update()
    {
        Console.WriteLine("Update Reminder");
    }

    public void Delete()
    {
        Console.WriteLine("Delete Reminder");
    }

    public void Display()
    {
        Console.WriteLine("Display Reminder");
        base.Display();
       // Console.WriteLine($"Reminder ID: {_reminderID}");
    }
}
