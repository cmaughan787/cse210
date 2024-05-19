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
        //SaveToFile(Journal._entries);
    }

    public static void SaveToFile(List<Journal> _entries)
    {
        Console.WriteLine("Saving journal...");
        string fileName = "MyJournal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
     
            foreach (Journal entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public static void LoadFromFile(string fileName)
    {
        Journal journal = new Journal();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                string[] parts = line.Split('\n');
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string content = parts[2];

                    Entry entry = new Entry(date, prompt, content);
                    journal.AddEntry(entry);
                }
            }
        }
        else
        {
            Console.WriteLine($"File {fileName} does not exist.");
        }
    }
}