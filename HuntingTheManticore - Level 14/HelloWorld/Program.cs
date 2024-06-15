bool flag = true;
int manticoreLocation = 0;
int cityHealth = 15;
int manticoreHealth = 10;
int cannonDamage = 1;
int desiredCannonRange = 0;
int round = 1;
string cannonResult = string.Empty;


StartGame();

while (flag)
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    DetermineCannonDamage();

    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
    Console.WriteLine("Enter desired cannon range:");

    desiredCannonRange = Convert.ToInt32(Console.ReadLine());

    DetermineCannonAccuracy();

    Console.WriteLine($"That round {cannonResult}", Console.ForegroundColor);
    DetermineGameResult();
    PrintBorder();
}

 void StartGame()
{
    Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore?");
    manticoreLocation = Convert.ToInt32(Console.ReadLine());
    //Add exceptions later
    Console.Clear();
    Console.WriteLine("Player 2, it is your turn");
    PrintBorder();
}

void PrintBorder()
{
    Console.ForegroundColor = ConsoleColor.White;
    for (int i = 0; i < 40; i++)
    {
        Console.Write("-");
    }
    Console.Write("\n");
}

void DetermineCannonDamage()
{
    if ((round % 3 == 0 && round % 5 == 0))
    {
        cannonDamage = 10;
        Console.ForegroundColor = ConsoleColor.Magenta;
    
    } 
    else if (round % 3 == 0) 
    {
        cannonDamage = 3;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    else if (round % 5 == 0)
    {
        cannonDamage = 3;
        Console.ForegroundColor = ConsoleColor.Blue;
    } 
    else 
    {
        cannonDamage = 1;
    }
}

void DetermineCannonAccuracy()
{
    if (desiredCannonRange > manticoreLocation)
    {
        cannonResult = "OVERSHOT the target";
    }
    else if (desiredCannonRange < manticoreLocation)
    {
        cannonResult = "FELL SHORT of the target";
    }
    else
    {
        cannonResult = "was a DIRECT HIT!";
        manticoreHealth -= cannonDamage;
    }
}

void DetermineGameResult()
{
    if (manticoreHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        flag = false;
    }

    if(flag != false )
    {
        cityHealth--;
        round++;
    }

    if (cityHealth == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("The city of Consolas has been destroyed!  The Manticore bellows in victory!");
        flag = false;
    }

}

