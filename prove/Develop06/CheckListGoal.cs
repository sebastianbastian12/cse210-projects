using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target = 0;
    private int _bonus = 0;

    public CheckListGoal(string shortName, string description, string points, int target, int bonus) : base (shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted+=1;
        if(_amountCompleted == _target)
        {
            int totalPoints = int.Parse(GetPoints()) + _bonus;
            Console.WriteLine($"Congratulations! You have earned {totalPoints}");
        }

        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} --- Currently Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckList Goal:{base.GetDetailsString()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }


}