using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment a1 = new Assignment("Mary Smith", "Division");
        Console.WriteLine(a1.GetSummary());


        MathAssignment a2 = new MathAssignment("John Doe", "Fractions", "6.4", "9-15");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Alice James", "Current Events", "Current Events in US Politics");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}