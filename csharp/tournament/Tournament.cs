using System;
using System.IO;
using System.Linq;	
using System.Text;
using System.Collections.Generic;

public static class Tournament
{   
    enum Result
    {	
        Loss = 0,
        Draw = 1,
        Win = 3
    }

    private static readonly Dictionary<string, (int played, int wins, int losses, int draws)> Results = new Dictionary<string, (int played, int wins, int losses, int draws)>();

    private const int BlankSpace = 31; 
    
    public static void Tally(Stream inStream, Stream outStream)
    {
        Results.Clear();

		using (StreamReader sr = new StreamReader(inStream))
        {
  			while(!sr.EndOfStream)
			{
				var game = sr.ReadLine();
				var gameParts = game.Split(';');

				string player1 = gameParts[0], player2 = gameParts[1];

				Enum.TryParse(gameParts[2], true, out Result result);

				AddResult(player1, result);
				AddResult(player2, SwitchResult(result));
			}
		}

        using (StreamWriter sw = new StreamWriter(outStream))
        {
            sw.Write(GenerateResultsTable());
        }        
    }

    private static void AddResult(string player, Result result)
    {
        int played = 0, wins = 0, losses = 0, draws = 0;

        if (Results.ContainsKey(player))
        {
            played = Results[player].played; 
            wins = Results[player].wins; 
            losses = Results[player].losses; 
            draws = Results[player].draws;
        }
        else
        {
            Results.Add(player, (played, wins, losses, draws));
        }

        switch(result)
        {
            case Result.Win : Results[player] = (played +1, wins +1, losses, draws);
                break;
            case Result.Loss : Results[player] = (played +1, wins, losses +1, draws);
                break;
            case Result.Draw : Results[player] = (played +1, wins, losses, draws +1);
                break;
        }  
    }

    private static Result SwitchResult(Result result)
    {
        switch (result)
        {
            case Result.Win : 
                return Result.Loss;
            case Result.Loss : 
                return Result.Win;
            default : 
                return Result.Draw;
        }
    }

    private static string GenerateResultsTable()
    {
        var sb = new StringBuilder("Team                           | MP |  W |  D |  L |  P\n");

        foreach(var kvp in Results.OrderByDescending(x => CalculateTotalPoints(x.Value.wins, x.Value.draws)).ThenBy(x => x.Key))
        {
            sb.Append($"{kvp.Key}{GenerateBlankSpace(kvp.Key.Count())}|  {kvp.Value.played} |  {kvp.Value.wins} |  {kvp.Value.draws} |  {kvp.Value.losses} |  {CalculateTotalPoints(kvp.Value.wins, kvp.Value.draws)}\n");
        }

        return sb.ToString().Trim('\n');
    }

    private static int CalculateTotalPoints(int wins, int draws)
    {
        return (wins * (int)Result.Win) + (draws * (int)Result.Draw);
    }

    private static string GenerateBlankSpace(int count)
    {
        return new string(' ', BlankSpace - count);
    }
}