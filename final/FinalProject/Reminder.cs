public class Reminder : Add
{
    public int _reminderID;


    public Reminder(string title, string description, Date date, int reminderID)
        : base(title, description, date)
    {
      _reminderID = reminderID;
    }

    public override void Create(Calendar calender)
    {
        
        Console.Write("Name Reminder: ");
        string title = Console.ReadLine();

        Console.Write("Write description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-MM-dd): ");
        string dateInput = Console.ReadLine();

        Console.Write("Enter unique reminder ID: ");
        int reminderID;
        if (int.TryParse(Console.ReadLine(), out reminderID))
        {
            // Successfully parsed _reminderID
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        if (DateTime.TryParseExact(dateInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
            Date date = new Date(parsedDate.Year, parsedDate.Month, parsedDate.Day);

            // Assign the values to the current Reminder instance
            _title = title;
            _description = description;
            _date = date;
            _reminderID = reminderID;

            Console.WriteLine("Reminder created successfully.");
            Reminder newReminder = new Reminder(_title, _description, _date, _reminderID);
            calender.AddReminder(newReminder);
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
        }
    }



    public override void Delete(Calendar calendar)
    {
        Console.Write("Enter Reminder ID to delete: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int reminderID))
    {
        if (input != null)
        {
            calendar.RemoveReminder(reminderID);
            Console.WriteLine("Reminder removed from calendar.");
        }
        else
        {
            Console.WriteLine("Reminder not found in calendar.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
    }

    public override void Display()
    {
        // Console.WriteLine("Display Reminder");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date.DisplayDate()}");
        Console.WriteLine($"Reminder ID: {_reminderID}");
    }
    
}
