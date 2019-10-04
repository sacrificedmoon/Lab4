using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{

    public class Player
    {
        public int playerhealth { get; set; }
        public string playerName { get; set; }
        public int playerMinDmg { get; set; }
        public bool alive;

        public Player()
        {
            this.playerhealth = 100;
            playerMinDmg = 10;
            alive = true;
        }

        public string PlayerInfo()
        {
            return String.Format("Welcome " + playerName + " prepare to ventuer down the evil dungen of whatevs");
        }



    }

}