public class Entry
{
    DateTime date;
    string text;

    public Entry(DateTime entryDate, string entryText)
    {
        date = entryDate;
        text = entryText;
    } 
    public void Display()
    {
        Console.WriteLine($"{date}, {text}");
    }
}

//     public void NewEntry()
//     {
//         Console.WriteLine("Enter the date: ");
//         string entrydate = Console.ReadLine();

//         string prompt = PromptGenerator.GeneratePrompt();
//         Console.WriteLine("Journal Prompt: ");
//         Console.WriteLine(prompt);

//         string journalentry = Console.ReadLine();
//         string completeentry = entrydate + prompt + journalentry;
//     }
//         public static List<string> journal = new List<string>
//         {
//             journal.Add(Jorentry.completeentry)
//         }
        

//         string fileName = "MyJournal.txt";
//     }
// 
