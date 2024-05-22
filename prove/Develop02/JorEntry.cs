public class Entry
{
    public DateTime date;
    public string text;
    public string jorprompt;


    public Entry(DateTime entryDate, string entryPrompt, string entryText)
    {
        date = entryDate;
        text = entryText;
        jorprompt = entryPrompt;

    } 
    public void Display()
    {
        Console.WriteLine($"Date: {date} \nPrompt: {jorprompt} \nEntry: {text}");
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
