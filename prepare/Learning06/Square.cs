using System;

public class Square : Shape 
{
    private double _side;

    public Square (string shapeName, string color, double side) : base (shapeName, color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }
}