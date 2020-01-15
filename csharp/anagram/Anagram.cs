using System;
using System.Linq;
using System.Collections.Generic;

public class Anagram
{
    private Dictionary<char, int> letters;
    private string baseWord;

    public Anagram(string baseWord)
    {
		this.letters = new Dictionary<char, int>();
        this.baseWord = baseWord;
		
        foreach(var letter in baseWord.ToLower().ToCharArray())
        {
            if(letters.ContainsKey(letter))
                letters[letter]++;
            else
                letters.Add(letter, 1);
        }
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        Dictionary<char, int> copyLetters;
        var results = new List<string>(potentialMatches.Where(x => x.Length == baseWord.Length && x.ToLower() != baseWord.ToLower()));

        foreach(var match in potentialMatches)
        {
            copyLetters = new Dictionary<char, int>(letters);    
            foreach(var c in match.ToLower().ToCharArray())
            {
                if(!(copyLetters.ContainsKey(c) && copyLetters[c] > 0))
                {
                    results.Remove(match);
                    break;
                }
                else
                {
                    copyLetters[c]--;
                }
            }
        }
        return results.ToArray();
    }
}