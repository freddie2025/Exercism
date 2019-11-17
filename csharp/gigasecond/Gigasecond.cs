using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        int gigaSecond = 1000000000;
        return moment.AddSeconds(gigaSecond);
    }
}