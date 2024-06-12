class BreatheActivity : Activity
{
    public BreatheActivity(string title, string welcome, int duration):base(title,welcome,duration)
        {
        
            Console.WriteLine($"{title}\n{welcome}\n\nDuration: {duration} seconds.");
            Console.WriteLine("Get Ready");
            Animation();

        int cycles = duration / 8; // Each cycle is 4 seconds (2 for inhale, 2 for exhale)
        
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nInhale...");
            Countdown(4);
            //Thread.Sleep(2000); // 2 seconds for inhaling
            Console.Write("\nExhale...");
            Countdown(4);
            //Thread.Sleep(2000); // 2 seconds for exhaling
        }

        Console.WriteLine("\n\nGood job!");
        Animation();
        Console.WriteLine($"\nYou have completed {duration} seconds of the breathing activity.");
        }
}