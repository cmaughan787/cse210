public class Reminder : Add
{
    private int _reminderID;
    private TimeSpan _time;

    public Reminder(string title, string description, Date date, int reminderID, TimeSpan time) 
        : base(title, description, date)
    {
        _reminderID = reminderID;
        _time = time;
    }

    public void Create()
    {
        // Method implementation here
    }

    public void Update()
    {
        // Method implementation here
    }

    public void Delete()
    {
        // Method implementation here
    }

    public void Display()
    {
        // Method implementation here
    }
}