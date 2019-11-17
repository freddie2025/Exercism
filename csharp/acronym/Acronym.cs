using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] phraseWords = Regex.Replace(phrase, "[^A-Za-z' ]", " ").Split(' ');
		return phraseWords.Aggregate(new StringBuilder(), (a,b) => {if(!String.IsNullOrWhiteSpace(b)) a.Append(b[0]); return a; }).ToString().ToUpper();
    }
}