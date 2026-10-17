using System.Reflection.Emit;

public class NumberHelper
{
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public int DoubleNumber(int number)
    {
        return number * 2;
    }

    public int GetAbsoluteValue(int number)
    {
        return Math.Abs(number);
    }
}
