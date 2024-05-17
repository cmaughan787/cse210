using System;

public class Menu
{
    public void DisplayMenu()
    {
        Journal startJournal = new Journal();
        Console.WriteLine("Welcome to your journal!");
        int q = 0;
        while (q != 1)
        {
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Save new entry");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select from menu:");
            int var1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(var1);
                            if (var1 > 5)
                        {
                            Console.WriteLine("Please enter a number from 1-5");
                        }
                            if (var1 == 1) 
                            {
                                PromptGenerator prompt3 = new PromptGenerator();
                                prompt3.testprompt();

                                string userInput = Console.ReadLine();
                                Entry entry = new Entry(DateTime.Now, userInput);
                                entry.Display();
                                startJournal._entries.Add(entry);
                                //startJournal._entries.Add(entry);
                            }
                            if (var1 == 2) 
                            {
                                Journal journal = new Journal();
                                journal.DisplayEntries();
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
                                Console.WriteLine("Thank you for visiting your journal! Goodbye.");
                                q = 1;
                            }
         }
    }
}
