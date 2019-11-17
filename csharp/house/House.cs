using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public static class House
{
 	private static readonly string[][] RhymeVerses = new string[][] 
	{
		new string[] {"house", "Jack built"},
		new string[] {"ate", "malt"},
		new string[] {"killed", "rat"},
		new string[] {"worried", "cat"},
		new string[] {"tossed", "dog"},
		new string[] {"milked", "cow", "with the crumpled horn"},
		new string[] {"kissed", "maiden", "all forlorn"},
		new string[] {"married", "man", "all tattered and torn"},
		new string[] {"woke", "priest", "all shaven and shorn"},
		new string[] {"kept", "rooster", "that crowed in the morn"},
		new string[] {"belonged to", "farmer", "sowing his corn"},
		new string[] {"horse", "hound", "horn"}
	}; 

	public static string Recite(int verseNumber)
    {
        var verse = 0;
		var stack = new Stack<string>();
		
		for(int i = 0; i < verseNumber; i++)
		{
			switch(i)
			{
				case 0: 
					stack.Push((i == verseNumber -1 ? "This is " : "that lay in ") + $"the {RhymeVerses[verse][0]} that {RhymeVerses[verse][1]}.");
					break;
				case int val when val >= 1 && val <= 4: 
					stack.Push((i == verseNumber -1 ? "This is " : $"that {RhymeVerses[verse][0]} ") + $"the {RhymeVerses[verse][1]} ");
					break;	
				case 11:
					stack.Push($"This is the {RhymeVerses[verse][0]} and the {RhymeVerses[verse][1]} and the {RhymeVerses[verse][2]} ");
					break;	
				default :
					stack.Push((i == verseNumber -1 ? "This is " : $"that {RhymeVerses[verse][0]} ") + $"the {RhymeVerses[verse][1]} {RhymeVerses[verse][2]} ");
					break;	
			}
			verse++;
		}
		
		return stack.Aggregate(new StringBuilder(), (a,b) => a.Append(b)).ToString();
    }

    public static string Recite(int startVerse, int endVerse)
    {
		var sb = new StringBuilder();
		
		for(int i = startVerse; i <= endVerse; i++)
		{
			sb.Append(Recite(i) + "\n");
		}
		
		return sb.ToString().Trim();
    }
}