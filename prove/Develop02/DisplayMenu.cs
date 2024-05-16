using System;

class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("1. Write an entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Load journal");
        Console.WriteLine("4. Save new entry");
        Console.WriteLine("5. Quit");
        Console.WriteLine("Select from menu:");
        int var1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(var1);
                        if (var1 > 5)
                    {
                        Console.WriteLine("Please enter a number from 1-5");
                    }
                        if (var1 == 1) 
                        {

                        }
                        if (var1 == 2) 
                        {
                            Console.WriteLine("2");
                        }
                        if (var1 == 3) 
                        {
                            Console.WriteLine("3");
                        }
                        if (var1 == 4) 
                        {
                            Console.WriteLine("4");
                        }
                        if (var1 == 5) 
                        {
                            Console.WriteLine("5");
                        }
    }
}

class PromptGenerator{
    
}