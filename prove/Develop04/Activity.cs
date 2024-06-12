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

    public void Animation()
    {
           int x = 0;
    while (x != 2)
    {
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            x += 1;
    }

    }
    public void Countdown(int sec)
    {
    
        for (int i = sec; i >= 1; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
            Console.Write("\b \b");

        }
        //Console.WriteLine("Begin");
    }

    public void Goodbye()
    {
        Console.WriteLine("Thank you for visiting the mindefullness app today. You are amazing, kill it today!");
    }

    // public void DisplayDiscript(string act, )
    // {

    // }
}