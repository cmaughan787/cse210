class Goal
{
    protected string _description;
    public int _points;
    protected string _title;

    public static List<Goal> goals = new List<Goal>();


    public Goal(string description, int points, string title)
    {
        _description = description;
        _points = points;
        _title = title;

    }

    public void GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What amount of points is associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public void SubMenu()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        int goaltype = int.Parse(Console.ReadLine());

        if (goaltype == 1)
        {
         GetInfo();
        }
        else if (goaltype == 2)
        {
         GetInfo();
        }
        else if (goaltype == 3)
        {
         GetInfo();
        }
    }
public static void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public static void SaveGoalsToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
    }

    public void DisplayGoal()
    {
      Console.WriteLine($"Title: {_title}, Description: {_description}, Points: {_points}");
    }

    public override string ToString()
    {
        return $"Title: {_title}, Description: {_description}, Points: {_points}";
    }

}