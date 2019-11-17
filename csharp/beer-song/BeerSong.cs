using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        var sb = new StringBuilder();

        for(int i = startBottles; i > (startBottles - takeDown); i--)
        {
			switch(i)
			{
				case 0 :
					sb.Append("No more bottles of beer on the wall, no more bottles of beer.\n");
            		sb.Append($"Go to the store and buy some more, 99 bottles of beer on the wall.");
					break;
				case 1 : 
					sb.Append($"{i} bottle of beer on the wall, {i} bottle of beer.\n");
					sb.Append($"Take it down and pass it around, no more bottles of beer on the wall.\n\n");
					break;
				case 2 : 
					sb.Append($"{i} bottles of beer on the wall, {i} bottles of beer.\n");
					sb.Append($"Take one down and pass it around, {i-1} bottle of beer on the wall.\n\n");
					break;
				default:
					sb.Append($"{i} bottles of beer on the wall, {i} bottles of beer.\n");
            		sb.Append($"Take one down and pass it around, {i-1} bottles of beer on the wall.\n\n");
					break;
			};
        }

        return sb.ToString().Trim();
    }
}