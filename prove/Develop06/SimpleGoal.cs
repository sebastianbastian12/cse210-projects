using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal (string shortName, string description, string points) : base (shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{GetDetailsString()},{GetPoints()},{IsComplete()}";
    }


}