using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4
{
    public class Monster : Tiles, IInteractable
    {
        public int monsterhealth { get; set; }
        public int monsterMinDmg { get; set; }
        public string monsterIcon { get; set; }
        public bool alive;

        public Monster(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Random r = new Random();

            monsterhealth = r.Next(10, 30);
            monsterMinDmg = r.Next(2, 10);
            alive = true;
            Symbol = 'M';
        }

        public void PlayerInteract() 
        {
            Player.numberOfMoves += 3;
        }
    }
}
