using System;
using System.IO;



public class Menu
{
    public Journal startJournal = new Journal();
     
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine();
        int q = 0;
        while (q != 1)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Save new entry");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Select for motivation!");
            Console.WriteLine();
            Console.Write("What would you like to do: ");
            int var1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(var1);
                            if (var1 > 6)
                        {
                            Console.WriteLine("Please enter a number from 1-6");
                        }
                            if (var1 == 1) 
                            {
                                PromptGenerator prompt3 = new PromptGenerator();
                                 string myprompt = prompt3.testprompt();
                                //Console.WriteLine(myprompt); // Uncomment for debug purposes
                                
                                
                                string userInput = Console.ReadLine();
                                //TODO: add 3rd entity to the constructor so it writes to the file.
                                
                                Entry entry = new Entry(DateTime.Now, myprompt, userInput);
                                // entry.Display(); // Uncomment for debug
                                startJournal._entries.Add(entry);
                                
;                                //startJournal._entries.Add(entry);
                            }
                            if (var1 == 2) 

                            {
                                Console.WriteLine("Displaying Journal entries.");
                                startJournal.DisplayEntries();
                                Console.WriteLine();
                            }
                            if (var1 == 3) 
                            {
                                //put a write asking for the filename
                            //string fileName ="MyJournal";
                            Console.Write("Please enter the file name:");
                            string fileName = Console.ReadLine();
                            // Journal myJournal = new Journal();
                            // myJournal = Journal.LoadFromFile(fileName, startJournal);
                            startJournal = startJournal.LoadFromFile(fileName, startJournal);
                            // Display loaded entries
                            Console.WriteLine("Displaying loaded journal entries:");
                            startJournal.DisplayEntries();
                            }
                        
                            if (var1 == 4) 
                            {
                            Console.WriteLine("Saving journal...");
                            Files file = new Files();
                            file.SaveToFile(startJournal);
                            }
                            if (var1 == 5) 
                            {
                                Console.WriteLine("Thank you for visiting your journal! Goodbye.");
                                q = 1;
                            }
                            if (var1 == 6)
                            {
                                Console.WriteLine("You can do it!!");
                            }
         }
    }
}
