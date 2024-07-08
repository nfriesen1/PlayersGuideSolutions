

namespace RockPaperScissors;

internal static class Program
{
    private static void Main()
    {
        var flag = true;
        Console.WriteLine("Welcome to Rock Paper Scissors!");
        Console.WriteLine("Player One enter your name: ");
        var playerOne = new Player(Console.ReadLine());
        Console.WriteLine("Player Two enter your name: ");
        var playerTwo = new Player(Console.ReadLine());
        var newGame = new Game(playerOne, playerTwo);
        while (flag)
        {
            newGame.Round();
            newGame.DisplayScore();
            Console.WriteLine("Play again? (y/n)");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "y":
                    break;
                default:
                    flag = false;
                    break;
            }
        }
        

    }
}