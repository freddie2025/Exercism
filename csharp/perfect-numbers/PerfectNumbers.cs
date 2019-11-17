using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number < 1) throw new ArgumentOutOfRangeException();

        int total = 0;

        for(int i = 1; i < number; i++)
        {
            if(number % i == 0) total += i;
        }

        if(total == number) 
            return Classification.Perfect;
        else if(total > number) 
            return Classification.Abundant;
        else 
            return Classification.Deficient;
    }
}
