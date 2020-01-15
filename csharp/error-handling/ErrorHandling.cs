using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        if(int.TryParse(input, out int output))
            return output;
        else
            return null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        return int.TryParse(input, out result);
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        {
            if(disposableObject != null) throw new Exception();
        }
        finally
        {
            disposableObject.Dispose();
        }
    }
}
