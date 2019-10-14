using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Key : Tiles, IInteractable
    {
        public Key(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'K';
        }
       
        public void PlayerInteract()
        {
            Player.HasKey = true;
            DungeonMap.roomObjectList.Remove(this);
            DungeonMap.roomObjectList.Add(new Floor(Xpos, Ypos, true));
            Console.WriteLine("You pick up a key.");
            Console.ReadKey(true);
        }
    }
}
