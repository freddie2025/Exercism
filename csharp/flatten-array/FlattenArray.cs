using System;
using System.Collections;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        foreach(var obj in input)
        {
            if(obj is null)
            {
                continue;
            }
            else if(obj is IEnumerable) 
            {
                foreach(var innerObj in Flatten(obj as IEnumerable)) 
                {
                    yield return innerObj;
                }
            }
            else 
            {
                yield return obj;
            }
        }
    }
}