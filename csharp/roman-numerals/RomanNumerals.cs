using System;
using System.Text;
using System.Collections.Generic;

public static class RomanNumeralExtension
{
	private static readonly Dictionary<int, string> RomanNumerals = new Dictionary<int, string>()
	{
		{1000,"M"}, {900,"CM"}, {500,"D"}, {400,"CD"}, {100,"C"}, {90,"XC"}, {50,"L"}, {40,"XL"}, {10,"X"}, {9,"IX"}, {5,"V"}, {4,"IV"}, {1,"I"}
	};
	
    public static string ToRoman(this int value)
    {
		if (value < 0 || value > 3999) throw new ArgumentException("Value must be in the range 0 - 3,999.");

		var sb = new StringBuilder();

		foreach(KeyValuePair<int, string> kvp in RomanNumerals)
		{
			while (value >= kvp.Key)
			{
				value -= kvp.Key;
				sb.Append(kvp.Value);
			}
		}
		
		return sb.Length == 0 ? "N" : sb.ToString();
    }
}