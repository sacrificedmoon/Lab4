using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4
{

    public class Player : Tiles
    {
        public int playerhealth { get; set; }
        public string playerName { get; set; }
        public int playerMinDmg { get; set; }
        public bool alive;

        public Player(int xPos, int yPos) : base(xPos, yPos) 
        {
            this.playerhealth = 100;
            playerMinDmg = 10;
            alive = true;
        }
        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("@");
            Console.ResetColor();
        }
        public string PlayerInfo()
        {
            return String.Format("Welcome " + playerName + " prepare to ventuer down the evil dungeon of whatevs");
        }



    }

}