using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _timesPerformed = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}." + "\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n" + "Well done!!" + "\n");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spiner = new List<string>();
        spiner.Add("|");
        spiner.Add("/");
        spiner.Add("-");
        spiner.Add("\\");

        // foreach (string i in spiner)
        // {
        //     Console.WriteLine(i);
        //     Thread.Sleep(1000);
        //     Console.WriteLine("\b \b");
        // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spiner[i];
            Console.Write(s); //Don´t forguet use .Write--not--.WriteLine
            Thread.Sleep(1000);
            Console.Write("\b \b"); //Don´t forguet use .Write--not--.WriteLine

            i++;

            if (i >= spiner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);  //Don´t forguet use .Write--not--.WriteLine
            Thread.Sleep(1000);
            Console.Write("\b \b");  //Don´t forguet use .Write--not--.WriteLine
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    //Core Requirement

     public void IncrementTimesPerformed()
    {
        _timesPerformed++;
    }

    public int GetTimesPerformed()
    {
        return _timesPerformed;
    }
}