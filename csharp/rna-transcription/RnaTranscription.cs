using System;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var sb = new StringBuilder();

        foreach(char c in nucleotide)
        {
            switch (c)
            {
                case 'G' :
                    sb.Append('C');
                    break;
                case 'C' :
                    sb.Append('G');
                    break;
                case 'T' :
                    sb.Append('A');
                    break;
                case 'A' :
                    sb.Append('U');
                    break;
                default: break;
            }
        } 

        return sb.ToString();
    }
}