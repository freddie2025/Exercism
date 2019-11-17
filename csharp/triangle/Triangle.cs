using System;
using System.Linq;
using System.Collections.Generic;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
		var sides = new HashSet<double>(){ side1, side2, side3 };
        return sides.Count == 3 && !sides.Contains(0) && IsTriangle(side1, side2, side3);
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        var sides = new HashSet<double>(){ side1, side2, side3 };
        return sides.Count <= 2 && !sides.Contains(0) && IsTriangle(side1, side2, side3);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        var sides = new HashSet<double>(){ side1, side2, side3 };
        return sides.Count == 1 && !sides.Contains(0) && IsTriangle(side1, side2, side3);
    }

	public static bool IsDegenerate(double side1, double side2, double side3) 
	{
		double[] sides = { side1, side2, side3 };
		var isDegenerate = (side1 + side2) == side3 || (side1 + side3) == side2 || (side2 + side3) == side1;
        return isDegenerate && !sides.Contains(0) && IsTriangle(side1, side2, side3);
	}

    private static bool IsTriangle(double side1, double side2, double side3)
	{
		return (side1 + side2) >= side3 && (side1 + side3) >= side2 && (side2 + side3) >= side1;
	}
}