using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        switch(statement.Trim())
		{
			case string i when i.Where(c => Char.IsLetter(c)).All(c => char.IsUpper(c)) && i.EndsWith("?") && i.Where(c => Char.IsLetter(c)).Count() > 0:	
				return "Calm down, I know what I'm doing!";
			case string i when i.Where(c => Char.IsLetter(c)).All(c => char.IsUpper(c)) && i.Where(c => Char.IsLetter(c)).Count() > 0:
				return "Whoa, chill out!";
			case string i when String.IsNullOrWhiteSpace(i):
				return "Fine. Be that way!";
			case string i when i.EndsWith("?"):
				return "Sure.";
			default:
				return "Whatever.";
    	}
    }
}