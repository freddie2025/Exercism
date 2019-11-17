using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> numbers = new HashSet<int>();

        foreach(int multiple in multiples.Where(x => x != 0))
        {
            for(int i = 1; i < max; i++)
            {
                if(i % multiple == 0) 
				{	
					numbers.Add(i);
				}
			}            
        }

        return numbers.Sum();
    }
}