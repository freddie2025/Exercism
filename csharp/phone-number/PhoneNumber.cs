using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string cleansed = Regex.Replace(phoneNumber, "[^0-9]", "").TrimStart('1');

        if(cleansed.Length == 10) 
        {
            if(Char.GetNumericValue(cleansed[0]) >= 2 && Char.GetNumericValue(cleansed[3]) >= 2) 
                return cleansed;
        }

        throw new ArgumentException();
    }
}