using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the magic number");
    
        string numberStr = Console.ReadLine();
        int number = int.Parse(numberStr);

        int guess = 0;
        do
        {

        Console.WriteLine("Enter a guess");
        string guessStr = Console.ReadLine();
        guess = int.Parse(Console.ReadLine());

        if (guess>number)
        {
          Console.WriteLine("Lower");  
        }
        else if (guess<number)
        {
            Console.WriteLine("Higher");
        }
        } while (guess!= number);
    }
}