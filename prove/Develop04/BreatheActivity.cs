class BreatheActivity : Activity
{
    public BreatheActivity(string title, string welcome, int duration):base(title,welcome,duration)
        {
        
            Console.WriteLine($"{title}\n{welcome}\nDuration: {duration} seconds.");

        int cycles = duration / 4; // Each cycle is 4 seconds (2 for inhale, 2 for exhale)
        
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Inhale...");
            Thread.Sleep(2000); // 2 seconds for inhaling
            Console.WriteLine("Exhale...");
            Thread.Sleep(2000); // 2 seconds for exhaling
        }

        Console.WriteLine("Thank your for participating in the breathing activity today");
        }
}