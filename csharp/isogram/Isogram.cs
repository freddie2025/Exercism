using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        return word.ToLower().Where(ch => Char.IsLetter(ch)).Distinct().Count() == word.ToLower().Where(ch => Char.IsLetter(ch)).Count();
    }
}
