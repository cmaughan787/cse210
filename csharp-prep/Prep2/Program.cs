using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr);
        
        string letter = "";
        // determine letter grade
    
        if (grade >= 90)
        {
            letter = "A";
        }
        else if(grade >=80)
        {
            letter = "B";
        }
        else if(grade >=70)
        {
            letter = "C";
        }
        else if(grade >=60)
        {
            letter = "D";
        }
        else if(grade < 60)
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congrats! Your grade is {letter}. You passed the class!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}.Try again, you can do it!");
        }
    }
}