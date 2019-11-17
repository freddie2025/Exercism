using System;
using System.Linq;
using System.Text;

public class SimpleCipher
{
	private static Random random = new Random();
	
    public SimpleCipher()
    {
    	this.Key = RandomString(100);
    }

    public SimpleCipher(string key)
    {
        this.Key = key;
    }
    
    public string Key { get; }

    public string Encode(string plaintext)
    {
        var sb = new StringBuilder();
		var keyPos = 0;
		
		for(int i = 0; i < plaintext.Length; i++)
		{
			sb.Append((char)((plaintext[i] + (Key[keyPos] - 97) > 122 && Key[keyPos] != 97 ? plaintext[i] - 26 : plaintext[i]) + (Key[keyPos] - 97)));
			if(keyPos == Key.Length -1) keyPos = 0; else keyPos++;
		}
		
		return sb.ToString();
    }

    public string Decode(string ciphertext)
    {
        var sb = new StringBuilder();
		var keyPos = 0;
		
		for(int i = 0; i < ciphertext.Length; i++)
		{
			sb.Append((char)((ciphertext[i] -(Key[keyPos] - 97) < 97 && Key[keyPos] != 97 ? ciphertext[i] + 26 : ciphertext[i]) - (Key[keyPos] - 97)));
			if(keyPos == Key.Length -1) keyPos = 0; else keyPos++;
		}
		
		return sb.ToString();
    }
		
	public static string RandomString(int length)
	{
		const string chars = "abcdefghijklmnopqrstuvwxyz";
		return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
	}
}