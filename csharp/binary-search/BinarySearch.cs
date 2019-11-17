using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        if(input.Length == 0) return -1;

        int minPoint = 0, maxPoint = input.Length -1;
			
		do
		{
			int midPoint = (minPoint + maxPoint) / 2;

            if (value > input[midPoint])
               minPoint = midPoint +1;
            else
               maxPoint = midPoint -1;
            
			if (input[midPoint] == value) return midPoint;
		}
		while(minPoint <= maxPoint);
		
		return -1;
    }
}