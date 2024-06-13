using System.Diagnostics;

class ReflectingActivity : Activity
{
        List<string> reflectPrompts = new List<string>
        {
            "Recall a moment when you overcame a significant challenge. What steps did you take to achieve this success, and what did you learn about your capabilities?",
            "Think of a time when you received positive feedback from someone you respect. What was the feedback, and how did it make you feel?",
            "Describe an instance where you set a goal and accomplished it. What motivated you to keep going, and how did you celebrate your achievement?",
            "Remember a project or task you completed that you are particularly proud of. What made this accomplishment special, and how did it impact others?",
            "Reflect on a time when you helped someone else succeed. What role did you play in their success, and what did this experience teach you about yourself?",
            "Think about a situation where you demonstrated resilience. How did you manage to stay focused and push through adversity?",
            "Recall a moment when you were at your best professionally. What were the circumstances, and what qualities did you exhibit that contributed to your success?",
            "Describe an instance where you exceeded your own expectations. What were the key factors that led to this outcome, and how did it influence your self-perception?",
            "Reflect on a time when you felt truly fulfilled and happy with your efforts. What were you doing, and why did it feel so rewarding?",
            "Think of a situation where you made a meaningful impact on a team or community. What actions did you take, and what was the result? How did this experience shape your understanding of your strengths?"
        };

                List<string> questions = new List<string>()
        {
            "In what way did this experience challenge you to grow?",
            "What surprised you the most about this experience?",
            "Did you face any obstacles during this experience? How did you overcome them?",
            "Would you approach this experience differently knowing what you know now? Why or why not?",
            "Who (if anyone) played a key role in making this experience meaningful for you?",
            "How did this experience connect to your values or passions?",
            "What specific skills or knowledge did you gain from this experience?",
            "Looking back, what moment stands out to you the most from this experience?",
            "How did this experience impact your perspective on something?",
            "If you could share one key takeaway from this experience, what would it be?",
            "Did this experience spark any new goals or interests for you?",
            "How did you celebrate this accomplishment (or the completion of the experience)?",
            "What emotions did you experience throughout this journey?",
            "Describe a time when you faced a similar challenge and how it relates to this experience.",
            "What advice would you give to someone considering a similar experience?",
            "How did this experience contribute to your overall sense of accomplishment?",
            "Did this experience change the way you approach challenges in general?",
            "Would you recommend this type of experience to others? Why or why not?",
            "Looking back, was there anything you could have done differently to prepare for this experience?",
            "How has this experience shaped your future aspirations or goals?",
            "What did you find most rewarding about this experience?",
            "Did you experience any moments of doubt during this experience? How did you deal with them?",
            "How did you measure your progress throughout this experience?",
            "What did you find most surprising about your own capabilities during this experience?",
            "How did you adapt and learn as you went through this experience?",
            "What were some of the biggest lessons you learned from this experience?",
            "How did you stay motivated throughout this experience?",
            "Did this experience influence any of your personal values or beliefs?",
            "What aspects of this experience would you like to replicate in the future?",
            "How will you use the knowledge and skills gained from this experience moving forward?"
        };


            public ReflectingActivity(string title, string welcome, int duration):base(title,welcome,duration)
        {

            Console.WriteLine("Get Ready...");
            Animation();
        
        Random random = new Random();
        int randomNumber = random.Next(0,10);

        string newPrompt = "";

        newPrompt = reflectPrompts[randomNumber];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {newPrompt} ---");

        Console.WriteLine("When you have something in mind, press enter to countinue.");

        // Loop until Enter key is pressed
        ConsoleKeyInfo cki;
        do
        {
        cki = Console.ReadKey();
        } while (cki.Key != ConsoleKey.Enter);
        // User pressed Enter, continue program 

        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(3);

        var startTime = DateTime.UtcNow;

        // Loop until the desired duration elapses
        while ((DateTime.UtcNow - startTime).TotalSeconds < duration)
        {
        int randomQ = random.Next(0,30);
        string newQ = "";
        newQ = questions[randomQ];
        Console.WriteLine($"{newQ}");
        Animation();
        Animation();
        }

        Console.WriteLine($"\nGood job! \nYou have completed {duration} seconds of the Reflecting activity.");
        Animation();
        }
}