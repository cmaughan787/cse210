using System;

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        //name 
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //all jobs in list
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }


}