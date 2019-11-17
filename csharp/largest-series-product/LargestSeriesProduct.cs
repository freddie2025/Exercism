using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
		// Brute Force
		double isDouble = 0;

		if((String.IsNullOrWhiteSpace(digits) && span > 0) || (!double.TryParse(digits, out isDouble) && !String.IsNullOrWhiteSpace(digits)) || digits.Length < span || span < 0) 
            throw new ArgumentException(); 
			
		if(span == 0) 
            return 1;

		long max = 0;

		for(int i = 0; i + span <= digits.Length; i++)
		{ 
			long sum = digits.Substring(i, span).ToCharArray().Select(n => Convert.ToInt32(Char.GetNumericValue(n))).Aggregate((a, b) => a * b); 
			if(sum > max) max = sum;
		}

		return max;
    }
}