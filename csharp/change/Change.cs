using System;
using System.Linq;

public static class Change
{
    public static int[] FindFewestCoins(int[] coins, int target)
    {
        int[] data;
        Array.Sort(coins);

        foreach(int coin in coins.Reverse())
        {
            if(coin <= target)
            {
                if(target % coin == 0)
                {
                    var change = target / coin;
                    data = new int[change];
                    data.AsSpan().Fill(coin);
                    return data;
                }
            }
        }
        return new int[] {0};
    }
}