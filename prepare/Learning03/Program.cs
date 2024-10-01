using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction constructor = new Fraction();

        string defaultFraction = constructor.DefaultFraction();
        Console.WriteLine(defaultFraction);

        string GetFractionString = constructor.GetFractionString(5);
        Console.WriteLine(GetFractionString);

        double GetDecimalValue = constructor.GetDecimalValue(3, 4);
        Console.WriteLine($"Getting the decimal value of the fraction between 3/4: {GetDecimalValue}");


       



  
    }
}