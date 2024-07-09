public class Event : Add
{
    private Date _startDate;
    private Date _endDate;
    private int _eventID;

    public Event(string title, string description, Date date, Date startDate, Date endDate, int eventID) 
        : base(title, description, date)
    {
        _startDate = startDate;
        _endDate = endDate;
        _eventID = eventID;
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