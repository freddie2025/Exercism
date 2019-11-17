using System;
using System.Collections.Generic;

public class Robot
{
    private static HashSet<string> existingRobots = new HashSet<string>();
    private static Random random = new Random();
    private const int maxPossibleRobotNames = 676_000; // might need to check my maths here
    private string _name;
    
    public string Name 
	{ 
		get { return _name; } 
		private set { _name = value; } 
	}

	public Robot()
	{
		Reset();
	}
	
    public void Reset()
    {
		char firstChar = (char)random.Next(65, 91);
       	char secondChar = (char)random.Next(65, 91);
        int numbers = random.Next(1, 1000);
		string padding = numbers < 100 ? numbers < 10 ? "00" : "0" : "";
		
		string newName = $"{firstChar}{secondChar}{padding}{numbers}";
		
		if(existingRobots.Add(newName))
            _name = newName;
		else if(existingRobots.Count == maxPossibleRobotNames) 
           throw new  ArgumentOutOfRangeException("Exhausted all robot names, no more names available!");
        else
            Reset(); 
	}
}