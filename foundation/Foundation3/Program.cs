using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> _activities = new List<Activity>()
        {
            new Runnning("Running", 45, 8.0),
            new Cycling("Cycling", 120, 20),
            new Swimming("Swimmming", 45, 15)
        };

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        
    }
}