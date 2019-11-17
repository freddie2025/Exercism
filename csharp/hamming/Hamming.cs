using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();
        
        return firstStrand.Zip(secondStrand, (a, b) => a.Equals(b) ? 0 : 1).Sum();
    }
}