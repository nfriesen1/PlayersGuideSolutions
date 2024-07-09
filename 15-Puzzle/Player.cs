namespace _15_Puzzle;

public class Player
{
    public int Moves { get; private set; }

    public string? Name { get; init; }

    public void DisplayMoves()
    {
        Console.WriteLine($"Number of moves: {Moves}");
    }

    public void MakeMove(Board board, Move move)
    {
        if (ValidMove(board, move))
        {
            Moves++;
        }
        else
        {
            Console.WriteLine("Invalid move.  Please try again.");
        }
        
    }
    
    private static bool ValidMove(Board board, Move move)
    {
        var isValid = false;
        int temp;
        var(row, col) = IndexOfMultiDimen(board.Tiles, move.Number);
        var (rowEmpty, colEmpty) = IndexOfMultiDimen(board.Tiles, 0);
        switch (move.Direction)
        {
            case Direction.Left:
                if (col != 0 && rowEmpty == row && colEmpty == col - 1)
                {
                    temp = board.Tiles[rowEmpty, colEmpty];
                    board.Tiles[rowEmpty, colEmpty] = board.Tiles[row, col];
                    board.Tiles[row, col] = temp;
                    isValid = true;
                }

                break;
            case Direction.Right:
                if (col != board.Size && rowEmpty == row && colEmpty == col + 1)
                {
                    temp = board.Tiles[rowEmpty, colEmpty];
                    board.Tiles[rowEmpty, colEmpty] = board.Tiles[row, col];
                    board.Tiles[row, col] = temp;
                    isValid = true;
                }

                break;
            case Direction.Up:
                if (row != 0 && rowEmpty == row - 1 && colEmpty == col)
                {
                    temp = board.Tiles[rowEmpty, colEmpty];
                    board.Tiles[rowEmpty, colEmpty] = board.Tiles[row, col];
                    board.Tiles[row, col] = temp;
                    isValid = true;
                }

                break;
            case Direction.Down:
                if (row != board.Size && rowEmpty == row + 1 && colEmpty == col)
                {
                    temp = board.Tiles[rowEmpty, colEmpty];
                    board.Tiles[rowEmpty, colEmpty] = board.Tiles[row, col];
                    board.Tiles[row, col] = temp;
                    isValid = true;
                }

                break;
        }

        return isValid;
    }

    private static (int, int) IndexOfMultiDimen(int[,] tiles, int value)
    {
        for (var i = 0; i < tiles.GetLength(0); i++)
        {
            for (var j = 0; j < tiles.GetLength(1); j++)
            {
                if (tiles[i, j] == value)
                {
                    return (i, j);
                }
            }
        }

        return (-1, -1); // Not found
    }
    
}
