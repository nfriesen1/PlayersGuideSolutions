namespace _15_Puzzle;

public class Move
{
    public int Number { get; init; }
    public Direction Direction { get; init; }
    
}

public enum Direction
{
    Left,
    Right,
    Up,
    Down
}