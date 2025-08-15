using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return GetDate().ToString("dd MMM yyyy") + " " + GetType().Name +
               " (" + GetMinutes() + " min) - " +
               "Distance: " + GetDistance().ToString("0.0") + " km, " +
               "Speed: " + GetSpeed().ToString("0.0") + " kph, " +
               "Pace: " + GetPace().ToString("0.00") + " min per km";
    }


}