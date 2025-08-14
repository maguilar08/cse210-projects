using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        IncrementTimesPerformed();  //C.R.
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("Get ready... ");
            ShowSpinner(3);
            Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);

            Console.Write("Now breath out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}