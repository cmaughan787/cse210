using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //get list
        int num = 1;
        List<int> series = new List<int>();
        
        while (num != 0)
            {
            Console.WriteLine("Please enter a number, type 0 when finished.");
            num = int.Parse(Console.ReadLine());

            if (num!=0)
                series.Add(num);
            }
    //sum
    int sum = 0;
    foreach (int number in series)
        {
            sum += number;
        }
    Console.WriteLine($"Sum: {sum}");
    //average
    float avg = ((float)sum) / series.Count;
    Console.WriteLine($"Average: {avg}");

    //max
    int max = series[0];
    foreach (int number in series)
        {
            if (number > max)
            {
                max = number;
            }
        }
    Console.WriteLine($"Maximum: {max}");
    }
}