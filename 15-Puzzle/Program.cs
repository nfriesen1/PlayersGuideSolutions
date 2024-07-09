// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace _15_Puzzle;


public class Program
{
    public static void Main()
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        
        Console.WriteLine("Welcome to 15 Puzzle!");
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        int size;
        var player = new Player
        {
            Name = name
        };
        while (true)
        {
            Console.WriteLine("How big would you like the board (3, 4, 5 tiles long)?");
            size = Convert.ToInt32(Console.ReadLine());
            if (size is < 2 or > 5)
            {
                Console.WriteLine("Board size must be between 3 to 5 tiles.");
            }
            else
            {
                break;
            }
        }

        var board = new Board(size);
        var game = new Game(board);
        int number;
        while (true)
        {
            player.DisplayMoves();
            board.PrintBoard();
            while (true)
            {
                Console.WriteLine("What number would you like to move?");
                var num = Console.ReadLine();
                if(int.TryParse(num, out var validNum))
                {
                    number = validNum;
                    break;
                } 
                Console.WriteLine("Invalid number.  Please try again");
            }
            Console.WriteLine("What direction would you like to move it (Left, Right, Up, Down)?");

            var input  = textInfo.ToTitleCase(Console.ReadLine() ?? string.Empty);
            Enum.TryParse(input, out Direction direction);
            var move = new Move
            {
                Number = number,
                Direction = direction
            };
            player.MakeMove(board, move);
            if (!game.IsWin()) continue;
            board.PrintBoard();
            Console.WriteLine($"Congratulations {player.Name}!  You won in {player.Moves} moves!");
            break;
        }

    }
}