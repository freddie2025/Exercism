using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public static class TwelveDays
{
    static SortedDictionary<int, Tuple<string, string>> Verses = new SortedDictionary<int, Tuple<string, string>>()
    {
		{1, new Tuple<string, string>("first", "a Partridge in a Pear Tree")},
        {2, new Tuple<string, string>("second", "two Turtle Doves, and ")},
        {3, new Tuple<string, string>("third", "three French Hens, ")},
        {4, new Tuple<string, string>("fourth", "four Calling Birds, ")},
        {5, new Tuple<string, string>("fifth", "five Gold Rings, ")},
        {6, new Tuple<string, string>("sixth", "six Geese-a-Laying, ")},
        {7, new Tuple<string, string>("seventh", "seven Swans-a-Swimming, ")},
        {8, new Tuple<string, string>("eighth", "eight Maids-a-Milking, ")},
        {9, new Tuple<string, string>("ninth", "nine Ladies Dancing, ")},
        {10, new Tuple<string, string>("tenth", "ten Lords-a-Leaping, ")},
        {11, new Tuple<string, string>("eleventh", "eleven Pipers Piping, ")},
        {12, new Tuple<string, string>("twelfth", "twelve Drummers Drumming, ")}
    };

    public static string Recite(int verseNumber)
    {
        return $"On the {Verses[verseNumber].Item1} day of Christmas my true love gave to me: {Verses.Take(verseNumber).Reverse().Aggregate(new StringBuilder(), (x, y) => x.Append(y.Value.Item2))}.";
    }

    public static string Recite(int startVerse, int endVerse)
    {
        var sb = new StringBuilder();
        for(int i = startVerse; i <= endVerse; i++)
        {
            sb.Append(Recite(i) + '\n');
        }
        return sb.ToString().Trim('\n');
    }
}