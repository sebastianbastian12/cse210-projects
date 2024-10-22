using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Square", "Purple", 25);
        /*DisplayingShapeInformation(square);*/
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(12, 8, "Rectangle", "Blue");
        /*DisplayingShapeInformation(rectangle);*/
        shapes.Add(rectangle);

        Circle circle =  new Circle(28, "Circle", "White");
        /*DisplayingShapeInformation(circle);*/
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            string name = shape.GetShapeName();
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Shape: {name} - Color : {color} - Area: {area}");

        }
    }

    /*public static void DisplayingShapeInformation(Shape shape) {
        double area = shape.GetArea();
        Console.WriteLine($"Shape: {shape.GetShapeName()} - Color : {shape.GetColor()} - Area: {shape.GetArea()}");
    }*/
}