using System;
using System.Xml.XPath;

public class Fraction {

    private int _numerator;
    private int _denominator;

    public string DefaultFraction()
    {
        _numerator = 10;
        _denominator = 15;
        string _defaultFraction = $"This is the default fraction: {_numerator}/{_denominator}";
        return _defaultFraction;
        
    }

    public string GetFractionString(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
        string _result = $"Getting the string fraction: {_numerator}/{_denominator}";
        return _result;

        
    }

    public double GetDecimalValue (double numerator, double denominator)
    {
        double _numerator = numerator;
        double _denominator = denominator;
        return _numerator / _denominator;
    }
}