using System;
using System.Reflection.Metadata;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal (string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetName()
    {
        return _shortName;
    }

    public string GetPoints()
    {
        return _points;
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();


}