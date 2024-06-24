using System;

class Program
{
    static void Main(string[] args)
    {
         int end = 0;
        int _points = 0;
        List<Goal> goals = new List<Goal>();

    while (end != 1)
    {
        // Goal menu = new Goal (title, _points, description); //Create inside the Sub menu!!!
        _points = 0;
        Console.WriteLine($"You have {_points} points");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("3. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit.");
        Console.Write("Select a choice from menu: ");
        int answer = int.Parse(Console.ReadLine());

                
        if (answer == 1)
        {
            Goal.SubMenu(goals);
        }
        else if (answer == 2)
        {
            Console.WriteLine("The goals are:");
            // Goal.DisplayGoal(goals);
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
}