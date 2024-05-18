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
    }
}