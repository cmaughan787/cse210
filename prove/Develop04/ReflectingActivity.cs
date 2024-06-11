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

            public ReflectingActivity(string title, string welcome, int duration):base(title,welcome,duration)
        {
            title = "Reflecting Activity";
            welcome = "Let's take a moment to explore experiences where you overcame challenges. This will help you discover your inner strength and how you can apply it to future obstacles.";
            duration = Duration();
        }
}