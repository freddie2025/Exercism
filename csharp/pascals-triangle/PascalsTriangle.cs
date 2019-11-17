using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int val = 1;
		
		for(int i = 0; i < rows; i++)
		{
			var currentList = new List<int>();

			for(int j = 0; j <= i; j++)
			{
				if(j == 0 || i == 0) val = 1;
				else val = val * (i - j + 1) / j;
				currentList.Add(val);
			}
			
        	yield return currentList;
		}
    }

}