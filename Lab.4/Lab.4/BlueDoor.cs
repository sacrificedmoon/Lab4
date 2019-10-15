using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class BlueDoor : Tiles, IInteractable
    {
        public bool isOpen { get; private set; } = false;
        public BlueDoor(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'B';
        }

        public override bool CanPass()
        {
           if(Player.HasBlueKey == true)
            return true;
           else 
                return false;
        }
        public void PlayerInteract()
        {
            if (isOpen = false && Player.HasBlueKey)
            {
                isOpen = true;
                Player.HasBlueKey = false;
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("You unlock the door with your key");
            }
            Console.ReadKey(true);
        }
    }
}
