using System;
using System.Linq;

public enum YachtCategory
{
    Ones = 1,
    Twos = 2,
    Threes = 3,
    Fours = 4,
    Fives = 5,
    Sixes = 6,
    FullHouse = 7,
    FourOfAKind = 8,
    LittleStraight = 9,
    BigStraight = 10,
    Choice = 11,
    Yacht = 12,
}

public static class YachtGame
{
    public static int Score(int[] dice, YachtCategory category)
    { 
        var mode = dice.GroupBy(i => i).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
       
        switch(category)
        {
            case YachtCategory.Ones: return dice.Where(x => x == 1).Sum();
            case YachtCategory.Twos: return dice.Where(x => x == 2).Sum();
            case YachtCategory.Threes: return dice.Where(x => x == 3).Sum();
            case YachtCategory.Fours: return dice.Where(x => x == 4).Sum();
            case YachtCategory.Fives: return dice.Where(x => x == 5).Sum();
            case YachtCategory.Sixes: return dice.Where(x => x == 6).Sum();
            case YachtCategory.FullHouse: return dice.Distinct().Count() == 2 && dice.Where(x => x == mode).Count() < 4 ? dice.Sum() : 0;
            case YachtCategory.FourOfAKind: return dice.Where(x => x == mode).Count() >= 4 ? dice.Where(x => x == mode).Take(4).Sum() : 0;  
            case YachtCategory.LittleStraight: return dice.Except(new[] {6}).Count() == 5 ? 30 : 0;
            case YachtCategory.BigStraight: return dice.Except(new[] {1}).Count() == 5 ? 30 : 0;
            case YachtCategory.Choice: return dice.Sum();
            case YachtCategory.Yacht: return dice.Distinct().Count() == 1 ? 50 : 0;
            default: return 0; 
        } 
    }
}

