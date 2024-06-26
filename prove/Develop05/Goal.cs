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
    public abstract string ToSaveString();
    public abstract override string ToString();
    public abstract void DisplayGoals();
    public abstract int CompleteGoal();
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
        Console.Write("Which type of goal would you like to create? ");
        int goaltype = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (goaltype == 1)
        {
            Simple simpleGoal = new Simple("", 0, "");
            simpleGoal.GetInfo();
            goals.Add(simpleGoal);
        }
        else if (goaltype == 2)
        {
            Eternal eternalGoal = new Eternal("", 0, "");
            eternalGoal.GetInfo();
            goals.Add(eternalGoal);
        }
        else if (goaltype == 3)
        {
            Checklist eternalCheck = new Checklist("", 0, "");
            eternalCheck.GetInfo();
            goals.Add(eternalCheck);
        }
    }


    public static void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

    public static void SaveGoalsToFile(string filename, int totalPoints)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"Points: {totalPoints}");
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToSaveString());
            }
        }
    }


       public class LoadResult
    {
        public List<Goal> Goals { get; set; }
        public int TotalPoints { get; set; }
    }

    public static LoadResult LoadGoalsFromFile(string filename)
    {
        List<Goal> loadedGoals = new List<Goal>();
        int totalPoints = 0;

        using (StreamReader reader = new StreamReader(filename))
        {
            string pointsLine = reader.ReadLine();
            totalPoints = int.Parse(pointsLine.Split(": ")[1]);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(", ");
                string goalType = parts[0].Split(": ")[0];
                string title = parts[0].Split(": ")[1];
                string description = parts[1];
                int points = int.Parse(parts[2].Split(" ")[0]);

                if (goalType == "Simple Goal")
                {
                    Simple simpleGoal = new Simple(title, points, description);
                    loadedGoals.Add(simpleGoal);
                }
                else if (goalType == "Eternal Goal")
                {
                    Eternal eternalGoal = new Eternal(title, points, description);
                    loadedGoals.Add(eternalGoal);
                }
                else if (goalType == "Checklist Goal")
                {
                    int count = int.Parse(parts[3].Split(" ")[0]);
                    Checklist checklistGoal = new Checklist(title, points, description);
                    //checklistGoal.SetCount(count);
                    loadedGoals.Add(checklistGoal);
                }
            }
        }

        return new LoadResult
        {
            Goals = loadedGoals,
            TotalPoints = totalPoints
        };
    }

    // public static void DisplayGoals(List<Goal> goals)
    // {
    //     foreach (var goal in goals)
    //     {
    //         Console.WriteLine($"[ ] {goal}");
    //     }
    // }

    
        // return $"{_title} ({_description})";
    

}