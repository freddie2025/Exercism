using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
    	return white.Row == black.Row || white.Column == black.Column;
    }

    public static Queen Create(int row, int column)
    {
        return new Queen(row, column);
    }
}