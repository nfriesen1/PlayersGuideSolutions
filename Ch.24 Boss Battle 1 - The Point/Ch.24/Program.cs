using System;
using Ch._24.Models;

class Program
{
    static void Main()
    {
        // Points
        Point pointOne = new Point(2, 3);
        Point pointTwo = new Point(-4, 0);

        Console.WriteLine("Points: \n");
        Console.WriteLine($"Point One: {pointOne.ToString()}.");
        Console.WriteLine($"Point Two:  {pointTwo.ToString()}.");

        // Colors

        Color custom = new Color(125, 127, 45);
        Color white = Color.White;

        Console.WriteLine("Colors: \n");
        try
        {
            Color color = new Color(256, 100, 50); // This will throw an exception
            Console.WriteLine($"Invalid Color: {color.ToString()}");

        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            Color color = new Color(100, 50, 25); // This should succeed
            Console.WriteLine($"Valid Color: {color.ToString()}");
            Console.WriteLine("Color created successfully.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine($"Custom Color: {custom.ToString()}.");
        Console.WriteLine($"White: {white.ToString()}.\n");

        // Cards

        foreach (CardColor color in Enum.GetValues<CardColor>())
        {
            foreach (CardRank rank in Enum.GetValues<CardRank>())
            {
                Card card = new Card(rank, color);
                Console.WriteLine(card.ToString());
            }
        }
    }
}
