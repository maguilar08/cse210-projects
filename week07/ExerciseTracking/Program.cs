using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 40, 20.0),
            new Swimming(new DateTime(2022, 11, 3), 25, 30),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}