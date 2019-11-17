using System;

public static class TwoFer
{
    public static string Speak(string name = "")
    {
        return String.Format("One for {0}, one for me.", String.IsNullOrEmpty(name) ? "you" : name);
    }
}
