using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
	private readonly List<int> ListOfHighScores;
	
	public HighScores(List<int> list)
    {
        ListOfHighScores = list;
    }

    public List<int> Scores()
    {
        return ListOfHighScores;
    }

    public int Latest()
    {
        return ListOfHighScores.Last();
    }

    public int PersonalBest()
    {
    	return ListOfHighScores.Max();
    }

    public List<int> PersonalTopThree()
    {
        return ListOfHighScores.OrderByDescending(x => x).Take(3).ToList();
    }
}