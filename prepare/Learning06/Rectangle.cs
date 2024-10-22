using System;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle (double length, double width, string shapeName, string color) : base(shapeName, color){
        _lenght = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _lenght * _width;
    }

}