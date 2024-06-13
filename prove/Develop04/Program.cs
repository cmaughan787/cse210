using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("test", "aver", 15);
    

        // activity.DisplayWelcome();
        // Console.WriteLine("Please select from menu:");
        // string answer = Console.ReadLine();
    string answer = "";
        
    while (answer != "quit")
    {
        activity.SelectMenu();
        answer = Console.ReadLine();
        Console.WriteLine($"You selected: {answer}"); // Debugging line to check the input

        // fix so it doesn't run through twice before asking again for input 
        
        if (answer == "1")
        {
            BreatheActivity breathe = new BreatheActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", activity.Duration());
        }
        else if (answer == "2")
        {
            ListingActivity list = new ListingActivity("Listing Activity", "Let's embark on a journey of positive self-discovery! This activity will guide you to brainstorm all the wonderful things in a particular area of your life", activity.Duration());
        }
        else if (answer == "3")
        {
            ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", "Let's take a moment to explore experiences where you overcame challenges. This will help you discover your inner strength and how you can apply it to future obstacles.", activity.Duration());
        }
        else if (answer =="4")
        {
            Inspiration inspiration = new Inspiration("Inspiration", "Let yourself relax and reflex on inspiration quotes.", activity.Duration());
        }
        else if (answer == "5")
        {
            activity.Goodbye();
            answer = "quit";
        }
        else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
     }
    }
}

// choose between 1, 2, 3 then ask how long the activity should last 