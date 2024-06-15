using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;
using Level_18___Classes.Enums;
using Level_18___Classes.Classes;

class Program
{
    static async Task Main()
    {
        TextInfo _textInfo = new CultureInfo("en-US", false).TextInfo;
        Arrow newArrow;

        Console.WriteLine("Welcome to Vin Fletcher's Arrows!");
        Console.WriteLine("Would you like a CUSTOM or STANDARD arrow?");
        while (true)
        {
            string choice = Console.ReadLine();
            if (choice.Equals("custom", StringComparison.OrdinalIgnoreCase))
            {
                string arrowheadType = GetArrowheadType(_textInfo);
                string fletchingType = GetFletchingType(_textInfo);
                double shaftLength = GetShaftLength();
                newArrow = new Arrow(shaftLength, ParseEnum<ArrowheadTypes>(arrowheadType), ParseEnum<FletchingTypes>(fletchingType));
                break;
            }
            else if (choice.Equals("standard", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Would you like The Elite Arrow, The Beginner Arrow, or The Marksman Arrow?");
                newArrow = MakeStandardArrow(_textInfo);
                break;
            } else
            {
                Console.WriteLine("Please choose a CUSTOM or STANDARD arrow.");
            }
        }

        Console.WriteLine($"Your new arrow will have a shaft length of {newArrow.ShaftLength} centimeters, {newArrow.ArrowheadType} arrowhead, and {newArrow.FletchingType} fletching.\n");
        Task makeArrowTask = MakeArrowAsync();

        await makeArrowTask;

        Console.WriteLine($"Your new arrow is all set! It will cost you {newArrow.Cost} gold.");
    }

    static string GetArrowheadType(TextInfo textInfo)
    {
        Console.WriteLine("What type of arrowhead would you like?");
        string arrowheadType;
        while (true)
        {
            arrowheadType = textInfo.ToTitleCase(Console.ReadLine());
            if (Enum.TryParse(typeof(ArrowheadTypes), arrowheadType, true, out _))
            {
                break;
            }
            Console.WriteLine("I do not have that type of arrowhead. Please pick another one.");
        }
        return arrowheadType;
    }

    static string GetFletchingType(TextInfo textInfo)
    {
        Console.WriteLine("Excellent choice! Now what type of fletching would you like?");
        string fletchingType;
        while (true)
        {
            fletchingType = textInfo.ToTitleCase(Console.ReadLine());
            if (Enum.TryParse(typeof(FletchingTypes), fletchingType, true, out _))
            {
                break;
            }
            Console.WriteLine("I do not have that type of fletching. Please pick another one.");
        }
        return fletchingType;
    }

    static double GetShaftLength()
    {
        Console.WriteLine("Another great choice! Finally, how long would you like the shaft to be? It must be between 60 and 100 cm.");
        double shaftLength;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out shaftLength) && shaftLength >= 60 && shaftLength <= 100)
            {
                break;
            }
            Console.WriteLine("The shaft length must be between 60 and 100 cm. Please try another length.");
        }
        return shaftLength;
    }

    static Arrow MakeStandardArrow(TextInfo textInfo)
    {
        Arrow newArrow;
        string arrowChoice;

        string[] validEliteChoices = { "the elite arrow", "elite arrow", "elite" };
        string[] validBeginnerChoices = { "the beginner arrow", "beginner arrow", "beginner" };
        string[] validMarksmanChoices = { "the marksman arrow", "marksman arrow", "marksman" };


        while (true)
        {
            arrowChoice = Console.ReadLine();
            if (validEliteChoices.Any(choice => arrowChoice.Equals(choice, StringComparison.OrdinalIgnoreCase)))
            {
                newArrow = Arrow.CreateEliteArrow();
                break;
            }
            else if (validBeginnerChoices.Any(choice => arrowChoice.Equals(choice, StringComparison.OrdinalIgnoreCase)))
            {
                newArrow = Arrow.CreateBeginnerArrow();
                break;
            }
            else if (validMarksmanChoices.Any(choice => arrowChoice.Equals(choice, StringComparison.OrdinalIgnoreCase)))
            {
                newArrow = Arrow.CreateMarksmanArrow();
                break;
            }
            else
            {
                Console.WriteLine("We do not sell that type of standard arrow.  Please choose again");
            }

        }
        Console.WriteLine($"{textInfo.ToTitleCase(arrowChoice)}, an excellent choice!");
        return newArrow;
    }

    static async Task MakeArrowAsync()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Making arrow");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(".");
                await Task.Delay(300);
            }
            Console.WriteLine("\n");
        }
    }

    static T ParseEnum<T>(string value)
    {
        return (T)Enum.Parse(typeof(T), value, true);
    }
}
