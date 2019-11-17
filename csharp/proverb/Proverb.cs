using System;
using System.Collections.Generic;

public static class Proverb
    {
    public static string[] Recite(string[] subjects)
    {
        var proverb = new List<string>(); 

        for(int i = 0; i < subjects.Length; i++)
        {
            if(i == subjects.Length -1)
                proverb.Add($"And all for the want of a {subjects[0]}.");
            else
                proverb.Add($"For want of a {subjects[i]} the {subjects[i+1]} was lost.");
        }

        return proverb.ToArray();
    }
}