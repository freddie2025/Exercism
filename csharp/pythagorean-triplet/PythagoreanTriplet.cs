using System;
using System.Linq;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
		int b = 0;

        for(int i = 1; (i + b) + (Math.Sqrt(i*i + b*b)) <= sum; i++)
        {
			b = i+1;
			
            for(int j = i+1; (i + j) + (Math.Sqrt(i*i + j*j)) <= sum; j++)
            {
                if((i + j) + (Math.Sqrt(i*i + j*j)) == sum) 
                {
                    yield return (a: i, b: j, c: (int)Math.Sqrt(i*i + j*j));
                }
            }
		}
    }
}