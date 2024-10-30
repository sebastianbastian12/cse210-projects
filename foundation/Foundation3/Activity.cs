using System;

public abstract class Activity
{
    private string _activityName;
    private int _minutes;

    DateTime today = DateTime.Now;

    public Activity(string activityName, int minutes)
    {
        _activityName = activityName;
        _minutes = minutes;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetCurrentDate()
    {
        return $"{today.ToShortDateString()}";
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"Date:{GetCurrentDate()} - Activity:{GetActivityName()} ({GetMinutes()}min) - Distance:{GetDistance()}km - Speed:{GetSpeed()}kph - Pace:{GetPace()}min per km";
    }
}