public abstract class Goal
{
    protected string _description;
    public int _points;
    protected string _title;

    public static List<Goal> goals = new List<Goal>();


    public Goal(string title, int points, string description)
    {
        _description = description;
        _points = points;
        _title = title;

    }

    public abstract void GetInfo();
    // {
    //     Console.Write("What is the name of your goal? ");
    //     _title = Console.ReadLine();
    //     Console.Write("What is a short description of it? ");
    //     _description = Console.ReadLine();
    //     Console.Write("What amount of points is associated with this goal? ");
    //     _points = int.Parse(Console.ReadLine());
    // }

    public static void SubMenu(List<Goal> goals)
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        int goaltype = int.Parse(Console.ReadLine());

        if (goaltype == 1)
        {
            Simple simpleGoal = new Simple("", 0, "");
            simpleGoal.GetInfo();
            goals.Add(simpleGoal);
        }
        else if (goaltype == 2)
        {
         //GetInfo();
        }
        else if (goaltype == 3)
        {
         //GetInfo();
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

    // public static void DisplayGoal(List<Goal> goals)
    // {
    //   Console.WriteLine($"Title: {_title}, Description: {_description}, Points: {_points}");
    // }

    public override string ToString()
    {
        return $"Title: {_title}, Description: {_description}, Points: {_points}";
    }

}