using System;
using System.Linq;

public static class Sieve
{    
    public static int[] Primes(int limit)
    {
        if(limit < 2) throw new ArgumentOutOfRangeException();

        var multiples = new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31};
        var numberList = Enumerable.Range(2, limit-1).ToList();

        foreach(int multiple in multiples.Where(x => x <= limit)) 
        {
            for(int i = 2; i <= limit / multiple; i++)
            {
                numberList.Remove(i * multiple);
            }
        }
        return numberList.ToArray();
    }
}