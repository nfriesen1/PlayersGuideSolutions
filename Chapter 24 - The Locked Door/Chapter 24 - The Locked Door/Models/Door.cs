using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_24___The_Locked_Door.Models
{
    public class Door
    {
        public string Password { private get; set; }
        public DoorState State { get; private set; }


        public Door(string password, DoorState state)
        {
            Password = password;
            State = state;
        }

        public void UnlockDoor(string password)
        {
            if (password == Password && State == DoorState.Locked)
            {
                State = DoorState.Closed;
                Console.WriteLine("You successfully unlocked the door!");
            }
            else if (password != Password)
            {
                Console.WriteLine("Password is incorrect. The door is still locked");
            }
            else
            {
                Console.WriteLine("You can only unlock a locked door");
            }
        }

        public void LockDoor()
        {
            if (State == DoorState.Closed)
            {
                State = DoorState.Locked;
                Console.WriteLine("You have locked the door.");
            }
            else
            {
                Console.WriteLine("You can only lock a closed door");
            }
        }

        public void CloseDoor()
        {
            if (State == DoorState.Open)
            {
                State = DoorState.Closed;
                Console.WriteLine("You have closed the door.");
            }
            else
            {
                Console.WriteLine("You can only close an open door.");
            }
        }

        public void OpenDoor()
        {
            if (State == DoorState.Closed)
            {
                State = DoorState.Open;
                Console.WriteLine("You have opened the door.");
            }
            else
            {
                Console.WriteLine("You can only open a closed door.");
            }
        }

        public void ResetPassword(string currentPassword, string newPassword)
        {
            if (currentPassword == Password)
            {
                Password = newPassword;
                Console.WriteLine("Password has been reset.");
            }
            else
            {
                Console.WriteLine("Given password is incorrect. Please try again.");
            }
        }
    }

    public enum DoorState
    {
        Locked,
        Open,
        Closed
    }
}
