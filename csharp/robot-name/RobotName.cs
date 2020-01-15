using System;
using System.Collections.Generic;

public class Robot
{
    private static HashSet<string> existingRobots = new HashSet<string>();
    private static Random random = new Random();
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
		do
        {
            _name = GenerateName();
        }
        while (existingRobots.Contains(_name));
		existingRobots.Add(_name);
	}
	
	private string GenerateName()
	{
		char firstChar = (char)random.Next(65, 91);
       	char secondChar = (char)random.Next(65, 91);
        int numbers = random.Next(1, 1000);
		string padding = numbers < 100 ? numbers < 10 ? "00" : "0" : "";
		
		return $"{firstChar}{secondChar}{padding}{numbers}"; 
	}
}