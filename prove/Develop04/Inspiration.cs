class Inspiration : Activity
{
    public Inspiration(string title, string welcome, int duration):base(title,welcome,duration)
        {
           
          List<string> newInspiration = new List<string>()
          {
            // Self-Care
            "Take care of your body. It's the only place you have to live.",  // Jim Rohn
            "A healthy body is a guest chamber for the soul; a sick body is a prison.",  // Michel de Montaigne
            "Self-care is not self-indulgence, it is self-preservation.",  // Audrey Lorde

            // Motivation and Growth
            "It's not about being perfect. It's about effort. Progress, not perfection.",  // Gabrielle Reece
            "The journey of a thousand miles begins with a single step.",  // Lao Tzu 
            "The best time to plant a tree was 20 years ago. The second best time is now.",  // Chinese Proverb

            // Mindfulness and Positivity
            "Peace is not the absence of conflict, it is the ability to handle it with grace.",  // Ronz Burton
            "A healthy mind in a healthy body.",  // Juvenal
            "Smile, it confuses the whole world.",  // Smile Quote

            // Healthy Habits and Consistency
            "Small changes, big results.",  // Unknown
            "Don't wait for the perfect moment, start where you are.",  // Marie Forleo
            "Consistency is key, not perfection.",  // Unknown

            // Celebrating Progress
            "You don't have to be great to start, but you have to start to be great.",  // Zig Ziglar 
            "Celebrate your victories, however small.",  // Winston Churchill
            "Progress, not perfection.",  // Unknown 

            // Bonus Quotes
            "The future depends on what you do today.",  // Mahatma Gandhi
            "Believe in yourself and all that you are. Know that there is something inside you that is greater than any obstacle.",  // Marian Wright Edelman
            "Wellness is the complete integration of physical, mental, and social well-being.",  // The World Health Organization
          };

        string inspo;
        {
        // Random random = new Random();
        // int randomNumber = random.Next(0,18);
        // inspo = newInspiration[randomNumber];
        // Console.WriteLine(inspo);


        Console.Write("\nBeginning in...");
        Countdown(3);

          var startTime = DateTime.UtcNow;

        // Loop until the desired duration elapses
        while ((DateTime.UtcNow - startTime).TotalSeconds < duration)
        {
        Random random = new Random();
        int randomNumber = random.Next(0,18);
        inspo = newInspiration[randomNumber];
        Console.WriteLine($"\n{inspo}");
        Animation();
        Animation();
        }
    }
    }
}