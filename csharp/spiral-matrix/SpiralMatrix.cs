using System;

public class SpiralMatrix
{
	[Flags] 
	public enum Direction
	{
		None 	= 0b0000,
		Right 	= 0b0001,
		Left 	= 0b0010, 
		Down 	= 0b0100, 
		Up 		= 0b1000,
		All 	= 0b1111,
	}
	
    public static int[,] GetMatrix(int size)
    {
		switch (size)
		{
			case 0:
			 	return new int[,] {{}};
          	case 1:	
				return new int[,] {{1}};
			default:
				
				int count = 1, row = 0, col = 0, maxRow = (size -1), maxCol = (size -1), minRow = 1, minCol = 0;
				var output = new int[size , size];
				var direction = Direction.Right;

				output[row, col] = count++;
				
				do
				{
					switch(direction)
					{
						case Direction.Right when col == maxCol:
							direction = ChangeDirection(direction);
							maxCol--;
							break;
						case Direction.Down when row == maxRow:
							direction = ChangeDirection(direction);
							maxRow--;
							break;
						case Direction.Left when col == minCol:
							direction = ChangeDirection(direction);
							minCol++;
							break;
						case Direction.Up when row == minRow:
							direction = ChangeDirection(direction);
							minRow++;
							break;
					}

					switch (direction)
					{
						case Direction.Right: 
							col++;
							break;
						case Direction.Down: 
							row++;
							break;
						case Direction.Left:
							col--;
							break;
						case Direction.Up:
							row--;
							break;
					}

					output[row, col] = count++;
				} 
				while (count <= Math.Pow(size, 2));
		
			return output;
		}

	    static Direction ChangeDirection(Direction direction)
		{
			return direction switch
			{
				Direction.Right => Direction.Down,
				Direction.Down => Direction.Left,
				Direction.Left => Direction.Up,
				Direction.Up => Direction.Right,
				_ => Direction.Right
			};
		}
	}
}