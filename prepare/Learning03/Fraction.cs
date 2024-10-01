using System;
using System.Xml.XPath;

public class Fraction {

    private int _numerator;
    private int _denominator;
    private string _result;


    public Fraction()
    {
        _numerator = 10;
        _denominator = 15;  
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 15;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFractionStringNumerator()
    {
         _result = $"{_numerator}";
        return _result;
    }

    public string GetFractionStringDenominator()
    {
        _result = $"{_denominator}";
        return _result;
    }

    public string GetFractionString()
    {
       _result = $"{_numerator}/{_denominator}";
        return _result;
    }

    public double GetDecimalValue ()
    {
        return (double)_numerator / (double)_denominator;
    }
}