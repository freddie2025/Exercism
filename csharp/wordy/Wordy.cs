using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Wordy
{        
    public static int Answer(string question)
    {
        var sb = new StringBuilder();
        var dt = new DataTable();
		var lastValueIsNumber = false;
		var bracketCounter = 0; 

        Dictionary<string, string> tokens = new Dictionary<string, string>()
        {
            {"plus", "+"},
            {"minus", "-"},
            {"multiplied", "*"},
            {"divided", "/"},
            {"cubed", ""}
        };
		
        foreach(string str in question.Replace('?', ' ').Trim().Split(' '))
        {
            if(Regex.IsMatch(str, "[0-9]"))
            {
				if(lastValueIsNumber == false)
					sb.Append(str);
				else
					throw new ArgumentException();

	            bracketCounter++;
				lastValueIsNumber = true;		
            }
            else if(tokens.ContainsKey(str))
            {
				if(lastValueIsNumber == true && tokens[str] != "cubed")
					sb.Append(tokens[str]);
				else
					throw new ArgumentException();

				bracketCounter++;
				lastValueIsNumber = false;
            }
			
			if(bracketCounter != 0 && bracketCounter % 3 == 0)
				sb.Insert(0, "(").Append(")");
        }

		if(String.IsNullOrWhiteSpace(sb.ToString()) || !lastValueIsNumber) throw new ArgumentException();
		
        return Convert.ToInt32(dt.Compute(sb.ToString(), ""));
    }
}