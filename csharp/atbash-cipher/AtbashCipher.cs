using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class AtbashCipher
{
    private static Dictionary<char,char> cipher = new Dictionary<char, char>()
    {
        {'a','z'}, {'b','y'}, {'c','x'}, {'d','w'}, {'e','v'}, {'f','u'},
        {'g','t'}, {'h','s'}, {'i','r'}, {'j','q'}, {'k','p'}, {'l','o'},
        {'m','n'}, {'n','m'}, {'o','l'}, {'p','k'}, {'q','j'}, {'r','i'},
        {'s','h'}, {'t','g'}, {'u','f'}, {'v','e'}, {'w','d'}, {'x','c'},
        {'y','b'}, {'z','a'}, {'1','1'}, {'2','2'}, {'3','3'}, {'4','4'}, 
		{'5','5'}, {'6','6'}, {'7','7'}, {'8','8'}, {'9','9'}, {'0','0'}
    };

    public static string Encode(string plainValue)
    {
        return Regex.Replace(plainValue.ToLower().ToCharArray().Where(x => Char.IsLetterOrDigit(x)).Aggregate(new StringBuilder(), (x,y) => x.Append(cipher[y])).ToString(), ".{5}", "$0 ").Trim();
    }

    public static string Decode(string encodedValue)
    {
        return encodedValue.ToLower().ToCharArray().Where(x => Char.IsLetterOrDigit(x)).Aggregate(new StringBuilder(), (x,y) => x.Append(cipher[y])).ToString().Trim();
    }
}
