using System;
using System.Collections.Generic;

public static class Strain
{
	public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
		foreach(var item in collection)
		{
			if(predicate(item)) yield return item;
		}
	}

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.Keep(item => !predicate(item));
    }
}