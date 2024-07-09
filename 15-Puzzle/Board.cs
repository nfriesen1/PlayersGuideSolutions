namespace _15_Puzzle;

public class Board(int size)
{
    public int[,] Tiles { get; } = InitializeBoard(size);

    public int Size { get; } = size;

    public int[,] WinningState { get; } = SetWinningState(size);

    public void PrintBoard()
    {
        for (var i = 0; i < Size; i++)
        {
            for (var j = 0; j < Size; j++)
            {
                if (Tiles[i,j] == 0)
                {
                    Console.Write("_" + "\t");
                }
                else
                {
                    Console.Write(Tiles[i,j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }

    private static int[,] InitializeBoard(int size)
    {
        var flatBoard = new int[size * size];
        for (var i = 0; i < flatBoard.Length; i++)
        {
            flatBoard[i] = i;
        }
        
        var board = new int[size, size];
        flatBoard = Randomize(flatBoard);

        var index = 0;
        
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                board[i, j] = flatBoard[index];
                index++;
            }
        }

        return board;
    }

    private static int[] Randomize(int[] flatBoard)
    {
        var rand = new Random();
        for (int i = flatBoard.Length - 1; i > 0; i--)
        {
            var j = rand.Next(0, flatBoard.Length);
            (flatBoard[i], flatBoard[j]) = (flatBoard[j], flatBoard[i]);
        }
        return flatBoard;
    }
    
    private static int[,] SetWinningState(int size)
    {
       
        var board = new int[size, size];
        var value = 1;
        
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                board[i, j] = value;
                value++;
            }
        }

        board[size-1, size-1] = 0;

        return board;
    }
    
}