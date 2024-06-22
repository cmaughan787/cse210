using System;

class Program
{
    static void Main(string[] args)
    {
        Goal menu = new Goal("as", 12, "qw");
        int _points = 0;
        Console.WriteLine($"You have {_points}");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("3. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit.");
        Console.WriteLine("Select a choice from menu: ");
        int answer = Console.Read();

                
        if (answer == 1)
        {
            menu.SubMenu();
        }
        else if (answer == 2)
        {
            Console.WriteLine("The goals are:");
            menu.DisplayGoal();
        }
        else if (answer == 3)
        {
            // asdf
        }
        else if (answer == 4)
        {
           // asdf
        }
        else if (answer == 5)
        {
            // asdf
        }
        else if (answer == 6)
        {
            // asdf
        }
        else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

    }
}