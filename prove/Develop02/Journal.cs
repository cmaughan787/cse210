public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
       // SaveToFile(Journal._entries);
        
    }

    public static void SaveToFile(List<Journal> _entries)
    {
        // SAVE THE FILE Menu item 4
        // Console.WriteLine("Saving journal...");
        // string fileName = Console.ReadLine();
        // using (StreamWriter outputFile = new StreamWriter(fileName, true))
        // {
     
        //     foreach (Journal entry in _entries)
        //     {
        //         outputFile.WriteLine(_entries.Display(_entries));
        //     }
        // }
    }

    public static Journal LoadFromFile(string fileName, Journal _entries)
    {
        Console.WriteLine("Reading journal from file.");
        // Journal _entries = new List<Journal>();
        // Journal alreeady created, delete all entries, rewrite journal with new entries from file
        // string fileName = "MyJournal";

        string[] lines = System.IO.File.ReadAllLines(fileName);
         
         return _entries;

    }   
    }
