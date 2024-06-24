class Eternal : Goal
{
    private int _count;

    public Eternal(string _description, int _points, string _title) : base(_description, _points, _title)
    {
        // Initialize additional fields specific to Eternal goals if needed
        _count = 0; // Example initialization
    }
    public override void GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What amount of points is associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    }