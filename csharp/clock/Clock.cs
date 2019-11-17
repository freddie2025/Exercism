using System;

public class Clock
{
	public Clock(int hours, int minutes)
	{
		if (minutes < 0)
		{
			hours = hours + minutes / 60 - 1;
			minutes = 60 + minutes % 60;
		}

		Minutes = minutes % 60;
		
		if (hours < 0)
		{
			hours = 24 + hours % 24;
		}
		
		Hours = (hours + minutes / 60) % 24;
		
	}

	public int Hours { get; } = 0;
	public int Minutes { get; } = 0;

	public Clock Add(int minutesToAdd)
	{
		return new Clock(Hours, Minutes + minutesToAdd);
	}

	public Clock Subtract(int minutesToSubtract)
	{
		return new Clock(Hours, Minutes - minutesToSubtract);
	}

	public override string ToString()
	{
		return $"{Hours:D2}:{Minutes:D2}";
	}

	public bool Equals(Clock other)
	{        
		if (other == null) return false;

		if (this.Hours == other.Hours && this.Minutes == other.Minutes)
		{
			return true;
		}
		else
		{	
			return false;
		}
	}

	public override bool Equals(object obj)
	{        
		if (obj == null || GetType() != obj.GetType())
		{
			return false;
		}
		else
		{
			Clock clockObj = obj as Clock;
			return clockObj == null ? false : Equals(clockObj);
		}
	}

	public static bool operator == (Clock clock1, Clock clock2)
	{
		if (((object)clock1) == null || ((object)clock2) == null)
			return Object.Equals(clock1, clock2);

		return clock1.Equals(clock2);
	}

	public static bool operator != (Clock clock1, Clock clock2)
	{
		if (((object)clock1) == null || ((object)clock2) == null)
			return ! Object.Equals(clock1, clock2);

		return ! (clock1.Equals(clock2));
	}

	public override int GetHashCode()
	{
		unchecked
		{
			return (Hours * 60 + Minutes);
		}
	}
}