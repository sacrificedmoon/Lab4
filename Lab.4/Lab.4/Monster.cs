using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4
{
    public class Monster : Tiles, IInteractable
    {
        public int monsterMinDmg { get; set; }

        public Monster(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Random r = new Random();
            monsterMinDmg = r.Next(2, 10);
            Symbol = 'M'; 
        }
        
        public void PlayerInteract() 
        {
            Player.numberOfMoves += monsterMinDmg;
        }
    }
}
