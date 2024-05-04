using System;

class Program
{
    static void Main(string[] args)
    {
        // ask the user for first name
        Console.Write("What is your first name?");
        string fname = Console.ReadLine();

        // ask the user for last name
        Console.Write("What is your last name?");
        string lname = Console.ReadLine();

        // print statement
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}