using System;

class Activity
{
    protected string _title;
    protected string _welcome;
    protected int _duration;

    // constructor 
    public Activity(string title, string welcome, int duration)
    {
        _title = title;
        _welcome = welcome;
        _duration = duration;
    }

    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to your mindfullness app!");
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Start breathing activity.");
        Console.WriteLine("2. Start Listing Activity.");
        Console.WriteLine("3. Start Reflecting Activity.");
        Console.WriteLine("4. Quit.");
    }
       

    public int Duration()
    {
        Console.WriteLine("How long would you like to do this activity in seconds?");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public void Countdown()
    {
    
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine("Begin");
    }

    public void Goodbye()
    {
        Console.WriteLine("Thank you for visiting the mindefullness app today. You are amazing, kill it today!");
    }

    // public void DisplayDiscript(string act, )
    // {

    // }
}