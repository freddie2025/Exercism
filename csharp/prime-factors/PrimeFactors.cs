using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static int[] Factors(long number)
    {
        var list  = new List<int>();
        int division = 2;

        do
        {
            if(number % division == 0)
            {
                list.Add(division);
                number = number / division;
                division = 2; 
            } 
            else division++;                
        } 
        while (number > 1);

        return list.ToArray();
    }
}