using System;
using System.Collections.Generic;
using System.Linq;

public static class ListOps
{
     public static int Length<T>(List<T> input)
    {
    	return input.Count();
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        return input.ToArray().Reverse().ToList();
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {
        var newList = new List<TOut>();
		
		foreach(var item in input)
		{
			newList.Add(map(item));
		}
		
		return newList;
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {
		var newList = new List<T>();
		
		foreach(var item in input)
		{
			if(predicate(item)) newList.Add(item);
		}
		
		return newList;
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        var accumulator = start;
		
        foreach (var item in input)
        {
            accumulator = func(accumulator, item);
        }
		
        return accumulator;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        var accumulator = start;
		
        foreach (var item in Reverse(input))
        {
            accumulator = func(item, accumulator);
        }
		
        return accumulator;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        return input.SelectMany(x => x).ToList();
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        return left.Concat(right).ToList();
    }
}