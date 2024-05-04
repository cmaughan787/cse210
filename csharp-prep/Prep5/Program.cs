using System;

class Program
{
    static void Main(string[] args)
    {
        //Welcome Message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
    
        // Name 
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        //Favorite Number 
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite member: ");
            int FavNum = int.Parse(Console.ReadLine());

            return FavNum;
        }

        //Squared number 
        static int SquareNumber(int number)
        {
            int square = number * number;
            
            return square;
        }
        
        //user name and squared number 
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
    }
}