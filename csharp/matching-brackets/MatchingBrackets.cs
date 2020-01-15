using System;
using System.Linq;
using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {{ '(', ')' }, { '{', '}' }, { '[', ']' }};
        Stack<char> brackets = new Stack<char>();

        try
        {
            foreach (char c in input)
            {
                if (bracketPairs.Keys.Contains(c))
                {
                    brackets.Push(c);
                }
                else if (bracketPairs.Values.Contains(c))
				{
					if (c == bracketPairs[brackets.Peek()])
					{
						brackets.Pop();
					}
					else
					{
						return false;
					}
				}
            }
        }
        catch
        {
            return false;
        }

        return brackets.Count == 0;
    }
}
