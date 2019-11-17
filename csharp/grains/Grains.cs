using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if(n < 1 || n > 64) 
            throw new ArgumentOutOfRangeException();
        else
            return (ulong)Math.Pow(2, n-1);
    }

    public static ulong Total()
    {
        return ulong.MaxValue;
    }
}