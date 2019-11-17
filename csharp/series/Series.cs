using System;
using System.Linq;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if(sliceLength < 1  || numbers.Length < 1 || sliceLength > numbers.Length) throw new ArgumentException();

        string[] slices = new string[(numbers.Length - sliceLength) + 1]; 

        for(int i = 0; i + sliceLength <= numbers.Length; i++)
        {
            slices[i] = (numbers.Substring(i, sliceLength));    
        }

        return slices;
    }
}