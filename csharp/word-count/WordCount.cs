using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        var wordCount = new Dictionary<string, int>();

        foreach(var word in Regex.Replace(phrase, "^[a-zA-Z][a-zA-Z0-9]*$", "").Split(' '))
        {
            if(wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount.Add(word, 1);
        }

        return wordCount; 
    }
}