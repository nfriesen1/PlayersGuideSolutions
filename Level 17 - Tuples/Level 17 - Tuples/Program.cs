
(string Type, string MainIngredient, string Seasoning) soup;



DisplayMenu();
Console.WriteLine("What type would you like?");
var type = Console.ReadLine();
Console.WriteLine("What main ingredient would you like?");
var main = Console.ReadLine();
Console.WriteLine("How would you like it to be seasoned?");
var seasoning = Console.ReadLine();
soup = (Type: type, MainIngredient: main, Seasoning: seasoning);
Console.WriteLine($"Here is your {soup.Seasoning} {soup.MainIngredient} {soup.Type} fresh off the stove!");
Console.WriteLine("Enjoy! :D");


static void DisplayMenu()
{
    Console.WriteLine("Welcome to Simula’s Soup Shop!");
    Console.WriteLine("Here are the menu options: ");
    Console.WriteLine($"TYPE: {Type.Soup}, {Type.Stew}, and {Type.Gumbo}");
    Console.WriteLine($"MAIN INGREDIENT: {Main.Potato}, {Main.Chicken}, {Main.Carrot}, and {Main.Mushroom}");
    Console.WriteLine($"SEASONING: {Seasoning.Salty}, {Seasoning.Spicy}, and {Seasoning.Sweet}");
}

enum Type
{
    Soup,
    Stew,
    Gumbo
}

enum Main
{
    Mushroom,
    Chicken,
    Carrot,
    Potato
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}