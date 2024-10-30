using System;

public  class Cycling: Activity
{
    private double _speed;

    public Cycling(string activityName, int minutes, double speed) : base(activityName, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round((_speed * GetMinutes()) / 60, 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}