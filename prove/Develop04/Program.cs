using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("test", "aver", 15);
    
    string answer = "";

    while (answer != "quit")
    {
        activity.DisplayWelcome();
        Console.WriteLine("Please select from menu:");
        answer = Console.ReadLine();
        
        if (answer == "1")
        {
            BreatheActivity breathe = new BreatheActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", activity.Duration());
        }
        else if (answer == "2")
        {
            ListingActivity breathe = new ListingActivity("Listing Activity", "Let's embark on a journey of positive self-discovery! This activity will guide you to brainstorm all the wonderful things in a particular area of your life", activity.Duration());
        }
        else if (answer == "3")
        {
            Console.WriteLine("Three");
        }
        else if (answer == "4")
        {
            Console.WriteLine("Four");
            answer = "quit";
            activity.Goodbye();
        }
     }
    }
}

// choose between 1, 2, 3 then ask how long the activity should last 