using System;
using System.Linq;

[FlagsAttribute]
public enum CommandAction
{
	wink = 1,
	double_blink = 2,
	close_your_eyes = 4,
	jump= 8,
	reverse = 16
}

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var commandActions = (CommandAction)commandValue;
		bool reverse = commandActions.HasFlag(CommandAction.reverse); 
		var secretHandshake = commandActions.ToString().Replace(" ", "").Replace('_', ' ').Split(',');
		
		return commandValue < 1 ? new string[] {} : reverse ? secretHandshake.Where(x => x != CommandAction.reverse.ToString()).Reverse().ToArray() : secretHandshake;
    }
}
