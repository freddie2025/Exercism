using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Concurrent;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        var CharacterCounts = new ConcurrentDictionary<char, int>();

		foreach(string s in texts)
		{
            Parallel.ForEach(s.ToLower().ToCharArray().Where(x => Char.IsLetter(x)), (currentCharacter) => 
			{
				CharacterCounts.AddOrUpdate(currentCharacter, 1, (key, oldValue) => oldValue + 1);
			});
		}
		
        return CharacterCounts.ToDictionary(entry => entry.Key, entry => entry.Value);
    }
}