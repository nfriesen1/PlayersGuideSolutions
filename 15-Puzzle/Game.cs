namespace _15_Puzzle;

public class Game(Board board)
{
    private readonly Board _board = board;

    public bool IsWin()
    {
        var isWin = true;
        for (var i = 0; i < _board.Size; i++)
        {
            for (var j = 0; j < _board.Size; j++)
            {
                if (_board.Tiles[i, j] != _board.WinningState[i, j])
                {
                    isWin = false;
                }
            }
        }

        return isWin;
    }
}