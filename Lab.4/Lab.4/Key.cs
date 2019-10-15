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
            Console.SetCursorPosition(0,13);
            Console.WriteLine("You pick up a blue key.");
            Console.ReadKey(true);
            Console.Clear();
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Blue Key");
        }
    }

    public class RedKey : Tiles, IInteractable
    {
        public RedKey(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'r';
        }
       
        public void PlayerInteract()
        {
            Console.SetCursorPosition(0, 11);
            Player.HasRedKey = true;
            DungeonMap.roomObjectList.Remove(this);
            DungeonMap.roomObjectList.Add(new Floor(Xpos, Ypos, true));
            Console.SetCursorPosition(0,13);
            Console.WriteLine("You pick up a red key.");
            Console.ReadKey(true);
            Console.Clear();
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Red Key");
        }
    }
}
