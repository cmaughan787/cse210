using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
    
        int number = Console.ReadLine();

        do
        {

        Console.WriteLine("Enter a guess");
        int guess = Console.ReadLine();
        if (guess>number)
        {
          Console.WriteLine("Lower");  
        }
        else if (guess<number)
        {
            Console.WriteLine("Higher");
        }
        } while (guess != number);
    }
}