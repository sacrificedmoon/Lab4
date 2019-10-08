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
        public const char playerIcon = '#';
        public bool alive;
        private int xPosition;
        private int yPosition;

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
        

        public void Write(char toWrite = playerIcon, int x = 0, int y = 0)
        {

            try
            {
                if(alive == true)
                {
                    if (x >= 0 && y >= 0) // 0-based
                    {
                        //sätt den gammla positionen till blank, eller kartan 
                        Console.SetCursorPosition(x, y);
                        Console.Write(toWrite);
                        
                    }
                }
                


            }
            catch (Exception)
            {
            }

            while (true)
            {
                var command = Console.ReadKey().Key;

                switch (command)
                {
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                }
                Write(toWrite, x, y);
            }
        }
    }

}