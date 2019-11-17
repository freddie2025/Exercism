using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distance	<= 1 ? 10 : distance <= 5 ? 5 : distance <= 10 ? 1 : 0;
    }
}
