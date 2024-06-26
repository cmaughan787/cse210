class Eternal : Goal
{
    public Eternal(string _description, int _points, string _title) : base(_description, _points, _title)
    {
        
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
        public override int CompleteGoal()
    {
        return _points;
    }

            public override void DisplayGoals()
        {
                Console.WriteLine($"[ ] {_title}, ({_description})");
        }



        public override string ToSaveString()
    {
        return $"Eternal Goal: {_title}, {_description}, {_points} points";
    }
        public override string ToString()
    {
        return $"{_title} ({_description})";
    }
}