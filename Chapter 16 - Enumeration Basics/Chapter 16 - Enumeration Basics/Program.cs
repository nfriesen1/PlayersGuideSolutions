/*
 Objectives:
• Define an enumeration for the state of the chest.
• Make a variable whose type is this new enumeration.
• Write code to allow you to manipulate the chest with the lock, unlock, open, and close
commands, but ensure that you don’t transition between states that don’t support it.
• Loop forever, asking for the next command.
*/

ChestState chestState = ChestState.Locked;
string action;

while(true)
{
    Console.WriteLine($"The chest is {chestState.ToString().ToLower()}. What do you want to do?");

    action = Console.ReadLine();
    HandleChestAction(ref chestState, action);


}

static void HandleChestAction(ref ChestState chestState, string action)
{
    bool invalidAction = false;
    switch (chestState)
    {
        case ChestState.Locked:
            if (action == "unlock")
                chestState = ChestState.Closed;
            else
                invalidAction = true;
            break;

        case ChestState.Closed:
            if (action == "open")
                chestState = ChestState.Open;
            else if (action == "lock")
                chestState = ChestState.Locked;
            else
                invalidAction = true;
            break;

        case ChestState.Open:
            if (action == "close")
                chestState = ChestState.Closed;
            else
                invalidAction = true;
            break;

        default:
            invalidAction = true;
            break;

    }
    if (invalidAction)
    {
        Console.WriteLine("Invalid Action.");
    }
}






enum ChestState
{
    Open,
    Closed,
    Locked
}
