using System;

class Program
{
    static void Main(string[] args)
    {
        //job 1
       Job job1 = new Job();
       job1._jobTitle = "FSY Counselor";        
       job1._company = "For Strength of Youth";
       job1._startYear = 2022;
       job1._endYear = 2023;

        //job 2
       Job job2 = new Job();
       job2._jobTitle = "Accounts Payable Intern";        
       job2._company = "Associated ELectric Cooperative";
       job2._startYear = 2023;
       job2._endYear = 2024;

    Resume myResume = new Resume();
    myResume._name = "Clara Maughan";
 
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.Display();


    }
}