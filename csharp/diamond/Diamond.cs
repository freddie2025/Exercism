using System;
using System.Text;
using System.Linq;

public static class Diamond
{
    public static string Make(char target)
    {
        if(target == 'A') return "A";
		
		var sb = new StringBuilder();
		var targetPostion = (int)target - 64;
		var emptyRow = new String(' ', (targetPostion*2) -1);
		var rowLength = emptyRow.Length;
		var leftIndex = (rowLength / 2);
		var rightIndex = (rowLength / 2);

		for(int i = 0; i <= (int)target - 65; i++)
		{
			char[] row = emptyRow.ToCharArray();
			row[leftIndex--] = (char)(i + 65);
			row[rightIndex++] = (char)(i + 65);
			sb.Append(row);
			sb.Append('\n');
		}

		sb.Append(new string(sb.ToString().Trim('\n').Reverse().ToArray()[(rowLength+1)..]));
		
		return sb.ToString().Trim('\n');
    }
}