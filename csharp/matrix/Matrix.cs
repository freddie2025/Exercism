using System;

public class Matrix
{
	private int[][] matrix;
	
    public Matrix(string input)
    {
		var rows = input.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
		
		matrix = new int[rows.Length][];
		
		for(int i = 0; i < rows.Length; i++)
		{ 
			matrix[i] = Array.ConvertAll(rows[i].Split(' '), int.Parse);
		}
    }

    public int Rows { get; }
    public int Cols { get; }

    public int[] Row(int row)
    {
        return matrix[row -1];
    }

    public int[] Column(int col)
    {
		var columnValues = new int[matrix.Length];
		
        for(int i = 0; i < matrix.Length; i++)
		{
			columnValues[i] = matrix[i][col -1];
		}
		
		return columnValues ;
    }
}