public class Add
{
    protected string _title;
    protected string _description;
    protected Date _date;

    public Add(string title, string description, Date date)
    {
        _title = title;
        _description = description;
        _date = date;
    }

    public void Display()
    {
        // abstract method
    }

    public void Create()
    {
        // abstract method
    }

    public void Delete()
    {
        // abstract method
    }

    public void Update()
    {
        // abstract method
    }

    public void AddItem(string title, string description, Date date)
    {
        // abstract method
    }
}