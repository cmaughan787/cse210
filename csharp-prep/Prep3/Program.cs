using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
     int number = randomGenerator.Next(1,100);

        int guess = 0;
        int numberGuesses = 0;
        string response = "";
        do 
        {
            do
            {

            Console.WriteLine("Enter a guess between 1 and 101");
            string guessStr = Console.ReadLine();
            guess = int.Parse(Console.ReadLine());
            numberGuesses++; 
        

            if (guess>number)
            {
            Console.WriteLine("Lower"); 
            }
            else if (guess<number)
            {
                Console.WriteLine("Higher"); 
            }
            else 
            {
                Console.WriteLine($"You guessed it with {numberGuesses} guesses!");
            }
            } while (guess!= number);

        Console.Write("Do you want to continue?");
        response = Console.ReadLine();
        } while (response == "yes");
    }
}