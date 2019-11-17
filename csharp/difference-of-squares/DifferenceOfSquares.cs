using System;
using System.Linq;

public static class DifferenceOfSquares
{
	public static int CalculateSquareOfSum(int max)
	{
		int squareOfSum = Enumerable.Range(1, max).Select(x => x).Sum();
		return squareOfSum * squareOfSum;
	}

	public static int CalculateSumOfSquares(int max)
	{
		int sumOfSquares = Enumerable.Range(1, max).Select(x => x * x).Sum();
		return sumOfSquares;
	}

	public static int CalculateDifferenceOfSquares(int max)
	{
		return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
	}
}