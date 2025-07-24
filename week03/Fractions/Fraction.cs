using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";  //  TO STRING: $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        double number = (double)_top / (double)_bottom;
        return number;
    }
    /* 
    POSIBLE SOLUTION TO:
     public double GetDecimalValue()
    {
        double number = _top / _bottom;
        return number;
    }

    *public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }

    *public double GetDecimalValue()
    {
        double numerator = (double)_top;
        double denominator = _bottom;
        double number = numerator / denominator;
        return number;
    }
    */
}

