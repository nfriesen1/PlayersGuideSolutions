namespace RockPaperScissors;

public class Player(string? name)
{
    public string? Name { get; set; } = name;
    public int Wins { get; set; } = 0;
    public Move Move { get; set; }
}

public enum Move
{
    Invalid,
    Rock,
    Paper,
    Scissors
}