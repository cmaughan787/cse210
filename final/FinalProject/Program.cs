class Program
{
    static void Main(string[] args)
    {
        int end = 0;
        Console.Clear();
        Console.WriteLine("Welcome to your calendar!");
        
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

        while (end != 1)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. View Calendar");
            Console.WriteLine("2. View Reminders");
            Console.WriteLine("3. View Events");
            Console.WriteLine("4. Edit Reminders");
            Console.WriteLine("5. Edit Events");
            Console.WriteLine("6. Daily Plan");
            Console.WriteLine("7. Why should I use a calander?");
            Console.WriteLine("8. Quit.");
            Console.Write("Select a choice from the menu: ");
            int answer;
            if (int.TryParse(Console.ReadLine(), out answer))
            {
                Console.WriteLine("");

                switch (answer)
                {
                    case 1:
                        // Code to view calendar
                        Calendar calendar = new Calendar();
                        calendar.DisplayCalendar();
                        break;

                    case 2:
                        reminder.Display();
                        break;

                    case 3:
                        eventObj.Display();
                        break;

                    case 4:
                        EditReminderMenu(reminder);
                        break;

                    case 5:
                        EditEventMenu(eventObj);
                        break;

                    case 6:
                        // Daily Plan
                        Console.WriteLine("Daily Plan.");
                        break;

                    case 7:
                        settings.WhyaCal();
                        break;

                    case 8:
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

    private static void EditReminderMenu(Reminder reminder)
    {
        int subChoice = 0;

        while (subChoice != 4)
        {
            Console.WriteLine("Select from the following options:");
            Console.WriteLine("1. Create Reminder");
            Console.WriteLine("2. Update Reminder");
            Console.WriteLine("3. Delete Reminder");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Enter your choice: ");
            
            if (int.TryParse(Console.ReadLine(), out subChoice))
            {
                switch (subChoice)
                {
                    case 1:
                        reminder.Create();
                        break;

                    case 2:
                        reminder.Update();
                        break;

                    case 3:
                        reminder.Delete();
                        break;

                    case 4:
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


    private static void EditEventMenu(Event eventObj)
    {
        int subChoice = 0;

        while (subChoice != 4)
        {
            Console.WriteLine("Select from the following options:");
            Console.WriteLine("1. Create Event");
            Console.WriteLine("2. Update Event");
            Console.WriteLine("3. Delete Event");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out subChoice))
            {
                switch (subChoice)
                {
                    case 1:
                        eventObj.Create();
                        break;

                    case 2:
                        eventObj.Update();
                        break;

                    case 3:
                        eventObj.Delete();
                        break;

                    case 4:
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