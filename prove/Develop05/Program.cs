using System;

class Program
{
    public static void ListGoals(List<Goal> goals)
    {   
        Console.WriteLine("Your goals are: ");
        for (int i = 0; i <goals.Count; i++)
        {
            Console.Write($"{i+1}. ");
            goals[i].DisplayGoals();
        }
    }

          public static void Animation()
    {
           int x = 0;
    while (x != 2)
    {
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            x += 1;
    }
    }
    static void Main(string[] args)
    {
         int end = 0;
        int _points = 0;
        List<Goal> goals = new List<Goal>();


    while (end != 1)
    {
        // Goal menu = new Goal (title, _points, description); //Create inside the Sub menu!!!
        Console.WriteLine($"\n You have {_points} points");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Tips for Goal Setting");
        Console.WriteLine("7. Quit.");
        Console.Write("Select a choice from menu: ");
        int answer = int.Parse(Console.ReadLine());
        Console.WriteLine("");

                
        if (answer == 1)
        {
            Goal.SubMenu(goals);
        }
        else if (answer == 2)
        {
            ListGoals(goals);
        }
        else if (answer == 3)
        {
            Console.Write("What is the file name for the file? Please include .txt ");
            string filename = Console.ReadLine();
            Goal.SaveGoalsToFile(filename, _points, goals);
            Console.Write("Saving...");
            Animation();
            // Console.WriteLine("FOR DEBUG");
            // foreach (var goal in goals)
            // {
            //     Console.WriteLine(goal.ToSaveString());
            // }
        }
        else if (answer == 4)
        {
            Console.Write("Enter the filename to load goals from: ");
            string filename = Console.ReadLine();
            var result = Goal.LoadGoalsFromFile(filename);
            goals = result.Goals;
            _points = result.TotalPoints;
            Console.Write("Loading goals...");
            Animation();
        }
        else if (answer == 5)
        {
                ListGoals(goals);
                Console.Write("Which goal did you complete? ");
                int compGoal = int.Parse(Console.ReadLine());
                compGoal -= 1;

                if (compGoal >= 0 && compGoal < goals.Count)
                {
                    _points += goals[compGoal].CompleteGoal();
                }
                else
                {
                    Console.WriteLine("Invalid goal number.");
                }
        }
        else if (answer == 6)
        {
            // SOURCE: OpenAI. (2024). ChatGPT [Large language model]. https://chatgpt.com
            Console.WriteLine("Tips for Goal Setting:");
            Console.WriteLine();
            Console.WriteLine("1. Be Specific");
            Console.WriteLine("   - Define your goals clearly. Instead of saying \"I want to be healthier,\" specify \"I want to exercise for 30 minutes, 5 times a week.\"");
            Console.WriteLine();
            Console.WriteLine("2. Make Goals Measurable");
            Console.WriteLine("   - Include precise amounts, dates, and other measurable data in your goals. This way, you can track your progress and know when you've achieved your goal.");
            Console.WriteLine();
            Console.WriteLine("3. Set Achievable Goals");
            Console.WriteLine("   - Ensure your goals are realistic and attainable within your abilities and resources. Setting unattainable goals can lead to frustration and loss of motivation.");
            Console.WriteLine();
            Console.WriteLine("4. Relevant Goals");
            Console.WriteLine("   - Your goals should be relevant to your overall objectives and align with your values and long-term plans. Make sure each goal is meaningful and contributes to your broader life goals.");
            Console.WriteLine();
            Console.WriteLine("5. Time-Bound Goals");
            Console.WriteLine("   - Set deadlines for your goals. This creates a sense of urgency and helps prevent procrastination. A deadline encourages consistent progress and helps you prioritize your efforts.");
            Console.WriteLine();
            Console.WriteLine("6. Break Down Goals");
            Console.WriteLine("   - Divide larger goals into smaller, manageable tasks. This makes big goals less overwhelming and helps you achieve consistent progress.");
            Console.WriteLine();
            Console.WriteLine("7. Write Down Your Goals");
            Console.WriteLine("   - Writing your goals down can make them feel more concrete and increase your commitment to achieving them. Keep them in a visible place to remind yourself regularly.");
            Console.WriteLine();
            Console.WriteLine("8. Create an Action Plan");
            Console.WriteLine("   - Develop a step-by-step plan outlining how you will achieve your goals. Include specific actions, resources needed, and timelines for each step.");
            Console.WriteLine();
            Console.WriteLine("9. Stay Flexible");
            Console.WriteLine("   - Be open to adjusting your goals as needed. Life circumstances can change, and being adaptable helps you stay on track even when faced with obstacles.");
            Console.WriteLine();
            Console.WriteLine("10. Monitor Progress");
            Console.WriteLine("   - Regularly review and assess your progress toward your goals. This helps you stay motivated, recognize achievements, and make necessary adjustments.");
            Console.WriteLine();
            Console.WriteLine("11. Stay Positive");
            Console.WriteLine("   - Maintain a positive mindset and focus on what you can achieve. Celebrate small successes along the way to keep your motivation high.");
            Console.WriteLine();
            Console.WriteLine("12. Seek Support");
            Console.WriteLine("   - Share your goals with friends, family, or a mentor who can provide encouragement, advice, and accountability.");
            Console.WriteLine();
            Console.WriteLine("13. Visualize Success");
            Console.WriteLine("   - Visualize yourself achieving your goals. This can enhance motivation and help you stay focused on your desired outcome.");
            Console.WriteLine();
            Console.WriteLine("14. Learn from Setbacks");
            Console.WriteLine("   - Accept that setbacks are part of the process. Learn from them and adjust your approach if necessary. Use challenges as opportunities to grow and improve.");
            Console.WriteLine();
            Console.WriteLine("15. Stay Committed");
            Console.WriteLine("   - Stay dedicated to your goals, even when the initial excitement wears off. Consistent effort and perseverance are key to achieving long-term success.");

        }
        else if (answer == 7)
        {
            end = 1;
        }
        else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

    }

    }
}