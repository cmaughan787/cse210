public class Simple : Goal
{
    private bool _complete;

    public Simple(string title, int points, string description)
        : base(title, points, description)
    {
        _complete = false;
    }

    public override void GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What amount of points is associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

        public override void DisplayGoals()
    {
        if(!_complete)
        {
            Console.WriteLine($"[ ] {_title}, ({_description})");
        }
        else
        {
            Console.WriteLine($"[X] {_title}, ({_description})");
        }
    }
        public override int CompleteGoal()
    {
        if (!_complete)
        {
            _complete = true;
            Console.WriteLine(_points);
            return _points;
            
        }
        return 0;
    }
        public override string ToSaveString()
    {
        return $"Simple Goal: {_title}, {_description}, {_points} points, Complete: {_complete}";
    }

        public override string ToString()
    {
        return $"{_title} ({_description})";
    }
}

