using System;
using Chapter_24___The_Locked_Door.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("What password would you like for your new door?");
        string password = Console.ReadLine();
        Door door = new Door(password, DoorState.Locked);
        while(true)
        {
            Console.WriteLine($"The door is currrently {door.State}.");
            Console.WriteLine("How would you like to interact with the door?");
            string action = Console.ReadLine();
            if(action.Equals("unlock", StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Please provide the password");
                string currentPassword = Console.ReadLine();
                door.UnlockDoor(currentPassword);
            } else if(action.Equals("open", StringComparison.OrdinalIgnoreCase))
            {
                door.OpenDoor();
            } else if(action.Equals("lock", StringComparison.OrdinalIgnoreCase)){
                door.LockDoor();
            } else if(action.Equals("close", StringComparison.OrdinalIgnoreCase))
            {
                door.CloseDoor();
            } else if(action.Equals("reset password", StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("What is the current password?");
                string oldPassword = Console.ReadLine();
                Console.WriteLine("What would you like the new password to me?");
                string newPassword = Console.ReadLine();
                door.ResetPassword(oldPassword, newPassword);
            } else
            {
                Console.WriteLine("Invalid action. Please try again.");
            }
        }
    }
}