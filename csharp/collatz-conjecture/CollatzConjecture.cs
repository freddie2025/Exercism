using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
		if(number == 1) return 0;
		if(number < 1) throw new ArgumentException(); 

		int count = 0;

		do
		{
			count++;
			if(number % 2 == 0) 
                number /= 2;
			else 
                number = (number * 3) +1;
		} 
		while(number != 1);

		return count;
    }
}