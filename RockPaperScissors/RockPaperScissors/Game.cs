namespace RockPaperScissors;

public class Game(Player playerOne, Player playerTwo)
{
    private Player PlayerOne { get; } = playerOne;
    private Player PlayerTwo { get; } = playerTwo;
    private int Draws { get; set; } = 0;

    public void Round()
    {
        while (true)
        {
            Console.WriteLine($"{PlayerOne.Name}, enter your move (Rock, Paper, or Scissors): ");
            Enum.TryParse(Console.ReadLine(), out Move playerOneMove);
            PlayerOne.Move = playerOneMove;
            Console.Clear();
            Console.WriteLine($"{PlayerTwo.Name}, enter your move (Rock, Paper, or Scissors): ");
            Enum.TryParse(Console.ReadLine(), out Move playerTwoMove);
            PlayerTwo.Move = playerTwoMove;
            if (PlayerOne.Move == Move.Invalid || PlayerTwo.Move == Move.Invalid)
            {
                Console.WriteLine($"{PlayerOne.Name} or {PlayerTwo.Name} made an invalid move.  Please try again");
                continue;
            }
            
            Console.WriteLine($"{PlayerOne.Name}'s Move: {PlayerOne.Move}");
            Console.WriteLine($"{PlayerTwo.Name}'s Move: {PlayerTwo.Move}");
            DetermineResult();

            break;
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"{PlayerOne.Name} Wins: {PlayerOne.Wins} | {PlayerTwo.Name} Wins: {PlayerTwo.Wins} | Draws: {Draws}");
    }

    private void DetermineResult()
    {
        switch (PlayerOne.Move)
        {
            case Move.Paper:
                switch (PlayerTwo.Move)
                {
                    case Move.Rock:
                        Win(PlayerOne);
                        break;
                    case Move.Scissors:
                        Win(PlayerTwo);
                        break;
                    default:
                        Draw();
                        break;
                }
                break;
            case Move.Scissors:
                switch (PlayerTwo.Move)
                {
                    case Move.Paper:
                        Win(PlayerOne);
                        break;
                    case Move.Rock:
                        Win(PlayerTwo);
                        break;
                    default:
                        Draw();
                        break;
                }
                break;
            case Move.Rock:
                switch (PlayerTwo.Move)
                {
                    case Move.Scissors:
                        Win(PlayerOne);
                        break;
                    case Move.Paper:
                        Win(PlayerTwo);
                        break;
                    default:
                        Draw();
                        break;
                }

                break;
        }
    }

    private static void Win(Player player)
    {
        player.Wins++;
        Console.WriteLine($"{player.Name} wins!");
    }

    private void Draw()
    {
        Draws++;
        Console.WriteLine("It's a draw!");
    }
}