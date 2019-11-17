using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {   
        int sum = 0;
		Char[] numbers = number.ToString().ToCharArray();
    	
		foreach(char c in numbers)
		{
			Char.GetNumericValue(c);
			sum += (int)(Math.Pow(Char.GetNumericValue(c), numbers.Length));
		}
		
		return sum == number;
    }
}