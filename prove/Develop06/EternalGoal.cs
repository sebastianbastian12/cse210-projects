using System;

public class EternalGoal : Goal
{
    public EternalGoal (string shortName, string description, string points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
      Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{GetDetailsString()},{GetPoints()}";
    }

}