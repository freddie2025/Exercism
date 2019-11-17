using System;

public static class ResistorColor
{
    private static string[] ResistorColors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

    public static int ColorCode(string color)
    {
        return Array.FindIndex(ResistorColors, x => x == color);
    }

    public static string[] Colors()
    {
        return ResistorColors;
    }
}