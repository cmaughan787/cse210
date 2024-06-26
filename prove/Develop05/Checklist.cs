class Checklist : Goal
{
    private int _count;
    private int _bonus;
    private int _current;

    public Checklist(string _description, int _points, string _title) : base(_description, _points, _title)
    {
        // Initialize additional fields specific to Eternal goals if needed
        _count = 0; // Example initialization
        _bonus = 0;
        _current = 0;
    }
    public override void GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What amount of points is associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _count = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

        public override string ToSaveString()
    {
        return $"Checklist Goal: {_title}, {_description}, {_points} points, {_bonus} bonus points, {_count} times to complete, {_current} completed";
    }

        public override string ToString()
    {
        return $"{_title} ({_description}) - Currently Completed: {_current}/{_count}";
    }

    public void ExtraPoints()
    {
        // if _coun
    }
    }
