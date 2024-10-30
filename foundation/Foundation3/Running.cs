using System;

public class Runnning: Activity
{

    private double _distance;
    public Runnning(string activityName, int minutes, double distance) : base (activityName, minutes)
    {
        _distance = distance;
    }


    public override double GetDistance()
    {
        return _distance;
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