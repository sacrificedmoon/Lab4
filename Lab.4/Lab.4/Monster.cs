using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Monster
    {
        public int monsterhealth { get; set; }
        public int monsterMinDmg { get; set; }
        public bool alive;

        public Monster()
        {
            Random r = new Random();

            monsterhealth = r.Next(10, 30);
            monsterMinDmg = r.Next(2, 10);
            alive = true;
        }
    }
}
