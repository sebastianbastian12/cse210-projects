using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction constructor = new Fraction();
        Console.WriteLine($"Here is the default fraction: {constructor.GetFractionString()}");
        Console.WriteLine($"Here is the decimal value from default fraction: {constructor.GetDecimalValue()}");
        Console.WriteLine($"Here is the numerator value from default fraction: {constructor.GetFractionStringNumerator()}");
        Console.WriteLine($"Here is the numerator value from default fraction: {constructor.GetFractionStringDenominator()}");
        Console.WriteLine();

        Fraction constructor2 = new Fraction(5);
        Console.WriteLine($"Here is the one parameter fraction: {constructor2.GetFractionString()}");
        Console.WriteLine($"Here is the decimal value from one parameter fraction: {constructor2.GetDecimalValue()}");
        Console.WriteLine($"Here is the numerator value from one parameter fraction: {constructor2.GetFractionStringNumerator()}");
    
        Console.WriteLine();

        Fraction constructor3 = new Fraction(3,4);
        Console.WriteLine($"Here is the two parameters fraction: {constructor3.GetFractionString()}");
        Console.WriteLine($"Here is the decimal value from the two parameters fraction: {constructor3.GetDecimalValue()}");
        Console.WriteLine($"Here is the numerator value from two parameters fraction: {constructor3.GetFractionStringNumerator()}");
        Console.WriteLine($"Here is the numerator value from two parameters fraction: {constructor3.GetFractionStringDenominator()}");
        Console.WriteLine();

        Fraction constructor4 = new Fraction(9);
        Console.WriteLine($"Here is the denominator value from one parameter fraction: {constructor4.GetFractionStringNumerator()}");
        Console.WriteLine();





    }
}