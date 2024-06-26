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

        public override string ToSaveString()
    {
        return $"Simple Goal: {_title}, {_description}, {_points} points, Complete: {_complete}";
    }

        public override string ToString()
    {
        return $"{_title} ({_description})";
    }
}

