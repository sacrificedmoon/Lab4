using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class BlueKey : Tiles, IInteractable
    {
        public BlueKey(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'b';
        }
       
        public void PlayerInteract()
        {
            Console.SetCursorPosition(0, 11);
            Player.HasBlueKey = true;
            DungeonMap.roomObjectList.Remove(this);
            DungeonMap.roomObjectList.Add(new Floor(Xpos, Ypos, true));

            Console.ReadKey(true);
            Console.SetCursorPosition(8, 23);
            Console.WriteLine("Blue Key");
        }
    }
}
