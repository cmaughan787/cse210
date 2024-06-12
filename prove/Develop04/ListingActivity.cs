using System.Text;
class ListingActivity : Activity
{
    public ListingActivity(string title, string welcome, int duration):base(title,welcome,duration)
        {
           
          List<string> listPrompts = new List<string>()
          {
            "List things you're looking forward to this week.",
            "Make a list of things you're grateful for today.",
            "Create a list of your favorite books (or movies, music, hobbies - customize based on user preference).",
            "List down things you accomplished this week (big or small).",
            "Think of people who inspire you and why.",
            "List down your top skills or talents.",
            "Make a list of places you dream of visiting someday.",
            "List things you'd like to learn more about.",
            "Think of ways you can practice self-care this week.",
            "List down things that make you unique."
          };

        string prompt;
    {
        Random random = new Random();
        int randomNumber = random.Next(0,10);

        prompt = listPrompts[randomNumber];
        Console.WriteLine(prompt);
        Console.WriteLine("Starting in...");
        Countdown(5);
        Console.WriteLine("Begin"); 
        
            Console.WriteLine("Enter your text for {0} seconds (press Enter for a new line): ", duration);
            StringBuilder textInput = new StringBuilder();

            DateTime startTime = DateTime.Now; // Get current time

            char key;
            while ((DateTime.Now - startTime) < TimeSpan.FromSeconds(duration)) // Loop for user-defined duration
            {
                key = (char)Console.Read();
                if (key == '\n')
                {
                    textInput.AppendLine(); // Add newline character for new line on Enter
                }
                else
                {
                    textInput.Append(key); // Add other characters to the string
                }
            }

            Console.WriteLine("Time is up!");
            Console.WriteLine("Thank your for participating in the listing activity today");
            Thread.Sleep(3000); // Pause for 3 seconds so it isn't so rushed2
    }

       
    }
        
    }
