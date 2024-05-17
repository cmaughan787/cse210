using System;


class Program
{
    static void Main(string[] args)
    {
       var test = new Menu();
        test.DisplayMenu();

        PromptGenerator prompt3 = new PromptGenerator();
        prompt3.testprompt();

        Entry entry = new Entry("May 15","hello");
        entry.Display();
    
    }
}                