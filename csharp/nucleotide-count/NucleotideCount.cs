using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> NucleotideCounts = new Dictionary<char, int>()
        {
            {'A',0}, {'C',0}, {'G',0}, {'T',0}
        };

        foreach(char c in sequence)
        {
            if(NucleotideCounts.ContainsKey(c))
                NucleotideCounts[c]++;
            else
                throw new ArgumentException();
        }
        
        return NucleotideCounts;
    }
}