using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming (string activityName, int minutes, int laps) : base(activityName, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round((_laps * 50) / 1000.0, 2);
    }
    
    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / GetMinutes()) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / GetDistance(), 2);
    }

}

