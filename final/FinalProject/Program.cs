class Program
{
    static void Main(string[] args)
    {
        int end = 0;
        Console.Clear();
        Console.WriteLine("Welcome to your calendar!");

        Calendar calendar = new Calendar();
        
        // Initialize dummy data for demonstration
        DateTime reminderDateTime = DateTime.ParseExact("2024-07-15 14:30:00", "yyyy-MM-dd HH:mm:ss", null);
        Date reminderDate = new Date(reminderDateTime.Year, reminderDateTime.Month, reminderDateTime.Day);
        Reminder reminder = new Reminder("Meeting", "Team meeting", reminderDate, 102);
        
        // Dummy dates for the event
        DateTime startDateTime = DateTime.ParseExact("2024-07-15 09:00:00", "yyyy-MM-dd HH:mm:ss", null);
        DateTime endDateTime = DateTime.ParseExact("2024-07-15 17:00:00", "yyyy-MM-dd HH:mm:ss", null);
        Date eventDate = new Date(startDateTime.Year, startDateTime.Month, startDateTime.Day);
        Date startDate = new Date(startDateTime.Year, startDateTime.Month, startDateTime.Day);
        Date endDate = new Date(endDateTime.Year, endDateTime.Month, endDateTime.Day);
        Event eventObj = new Event("Conference", "Tech conference", eventDate, startDate, endDate, 101);
        Why settings = new Why();
        DateTime holidayDate = DateTime.ParseExact("2024-07-15 09:00:00", "yyyy-MM-dd HH:mm:ss", null);
        Holiday holiday = new Holiday("Birthday", holidayDate, "Friend's birthday", new Date(holidayDate.Year, holidayDate.Month, holidayDate.Day));
        DailyPlan plan = new DailyPlan();
       
       while (end != 1)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. View Calendar");
            Console.WriteLine("2. View Reminders");
            Console.WriteLine("3. View Events");
            Console.WriteLine("4. Edit Reminders");
            Console.WriteLine("5. Edit Events");
            Console.WriteLine("6. Edit Holidays");
            Console.WriteLine("7. Daily Plan");
            Console.WriteLine("8. Why should I use a calander?");
            Console.WriteLine("9. Quit.");
            Console.Write("Select a choice from the menu: ");
            int answer;
            
            if (int.TryParse(Console.ReadLine(), out answer))
            {
                Console.WriteLine("");

                switch (answer)
                {
                    case 1:
                        
                        calendar.DisplayCalendar();
                        break;

                    case 2:
                        calendar.DisplayReminders();
                        break;

                    case 3:

                        calendar.DisplayEvents();
                        break;

                    case 4:
                        EditReminderMenu(reminder, calendar);
                        break;

                    case 5:
                        EditEventMenu(eventObj, calendar);
                        break;

                    
                    case 6:
                        EditHolidayMenu(holiday, calendar);
                        
                        break;

                    case 7:
                        // Daily Plan
                        DailyPlan(plan);
                        break;

                    case 8:
                        settings.WhyaCal();
                        break;

                    case 9:
                        Console.WriteLine("Have a good day!");
                        end = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private static void EditReminderMenu(Reminder reminder, Calendar calendar)
    {
        int subChoice = 0;

        while (subChoice != 3)
        {
            Console.WriteLine("\n\nSelect from the following options:");
            Console.WriteLine("1. Create Reminder");
            Console.WriteLine("2. Delete Reminder");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Enter your choice: ");
            
            if (int.TryParse(Console.ReadLine(), out subChoice))
            {
                switch (subChoice)
                {
                    case 1:
                        reminder.Create(calendar);
                        break;

                    case 2:
                        reminder.Delete(calendar);
                        break;

                    case 3:
                        // Exit mini-menu and return to main menu
                        Console.WriteLine("Returning to main menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }


    private static void EditEventMenu(Event eventObj, Calendar calendar)
    {
        int subChoice = 0;

        while (subChoice != 3)
        {
            Console.WriteLine("\n\nSelect from the following options:");
            Console.WriteLine("1. Create Event");
            Console.WriteLine("2. Delete Event");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out subChoice))
            {
                switch (subChoice)
                {
                    case 1:
                        eventObj.Create(calendar);
                        break;

                    case 2:
                        eventObj.Delete(calendar);
                        break;

                    case 3:
                        // Exit mini-menu and return to main menu
                        Console.WriteLine("Returning to main menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private static void EditHolidayMenu(Holiday holiday, Calendar calendar)
{
    int subChoice = 0;

    while (subChoice != 3)
    {
        Console.WriteLine("\n\nSelect from the following options:");
        Console.WriteLine("1. Create Holiday");
        Console.WriteLine("2. Delete Holiday");
        Console.WriteLine("3. Back to Main Menu");
        Console.Write("Enter your choice: ");

        if (int.TryParse(Console.ReadLine(), out subChoice))
        {
            switch (subChoice)
            {
                case 1:
                    holiday.Create(calendar);
                    break;

                case 2:
                    holiday.Delete(calendar);
                    break;

                case 3:
                    // Exit mini-menu and return to main menu
                    Console.WriteLine("Returning to main menu...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
    private static void DailyPlan(DailyPlan plan)
    {
        int subChoice = 0;

        while (subChoice != 3)
        {
            Console.WriteLine("\n\nSelect from the following options:");
            Console.WriteLine("1. View Best Practices");
            Console.WriteLine("2. View Example");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out subChoice))
            {
                switch (subChoice)
                {
                    case 1:
                        plan.BestPractices();
                        break;

                    case 2:
                        plan.Example();
                        break;

                    case 3:
                        // Exit mini-menu and return to main menu
                        Console.WriteLine("Returning to main menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

}