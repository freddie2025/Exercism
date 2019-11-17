using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
		StringBuilder sb = new StringBuilder();
		
		foreach(char c in text)
		{
			int rollbackPoint = Char.IsLower(c) ? 122 : 90;
			
			if(Char.IsLetter(c))
				sb.Append(c + shiftKey > rollbackPoint ? (char)(c + shiftKey - 26) : (char)(c + shiftKey));
			else
				sb.Append(c);
		}
		
        return sb.ToString();
    }
}