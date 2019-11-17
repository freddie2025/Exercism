using System;
using System.Collections.Generic;

public enum Plant
{
    Violets = 'V',
    Radishes = 'R',
    Clover = 'C',
    Grass = 'G'
}

public class KindergartenGarden
{    
	private readonly Dictionary<string, Plant[]> Children = new Dictionary<string, Plant[]>() 
	{
		{"Alice", new Plant[4]},
		{"Bob", new Plant[4]}, 
		{"Charlie", new Plant[4]}, 
		{"David", new Plant[4]}, 
		{"Eve", new Plant[4]}, 
		{"Fred", new Plant[4]}, 
		{"Ginny", new Plant[4]}, 
		{"Harriet", new Plant[4]}, 
		{"Ileana", new Plant[4]}, 
		{"Joseph", new Plant[4]}, 
		{"Kincaid", new Plant[4]}, 
		{"Larry", new Plant[4]}
	};
	
    public KindergartenGarden(string diagram)
    {
		var plants = diagram.Split(new[] { "\n" }, StringSplitOptions.None);
		var counter = 0; 

		foreach(KeyValuePair<string, Plant[]> kvp in Children)
		{
			kvp.Value[0] = (Plant)plants[0][counter];
			kvp.Value[1] = (Plant)plants[0][counter +1];
			kvp.Value[2] = (Plant)plants[1][counter];
			kvp.Value[3] = (Plant)plants[1][counter +1];
			
			if(counter + 2 > plants[0].Length -1) break; else counter = counter + 2;
		}
    }

    public IEnumerable<Plant> Plants(string student)
    {
		foreach(var plant in Children[student])
		{
        	yield return plant;
		}
    }
}