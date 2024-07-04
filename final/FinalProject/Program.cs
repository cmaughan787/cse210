using System;

class Program
{
    int _end = 0;
    static void Main(string[] args)
    {
        int end = 0;
        Console.WriteLine("Welcome to your calander!");
        while (end != 1)
    {
        // Goal menu = new Goal (title, _points, description); //Create inside the Sub menu!!!

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. View Calander");
        Console.WriteLine("2. View Reminders");
        Console.WriteLine("3. See Events");
        Console.WriteLine("4. Daily Plan");
        Console.WriteLine("5. Access Settings");
        Console.WriteLine("6. Quit.");
        Console.Write("Select a choice from menu: ");
        int answer = int.Parse(Console.ReadLine());
        Console.WriteLine("");

                
        if (answer == 1)
        {
            //
        }
        else if (answer == 2)
        {
            //
        }
        else if (answer == 3)
        {
            //
        }
        else if (answer == 4)
        {
            //
        }
        else if (answer == 5)
        {
            //
        }
        else if (answer == 6)
        {
            Console.WriteLine("Have a good day!");
           end =1;
        }

        else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

    }

    }
}