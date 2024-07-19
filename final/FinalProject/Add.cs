public abstract class Add
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

    public abstract void Display();

    public abstract void Create(Calendar calender);

    public abstract void Delete(Calendar calendar);



    public void AddItem(string title, string description, Date date)
    {
        // abstract method
    }
}