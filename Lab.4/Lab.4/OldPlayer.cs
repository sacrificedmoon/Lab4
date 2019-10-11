using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4
{

    public class OldPlayer : Tiles
    {
        public int playerhealth { get; set; }
        public string playerName { get; set; }
        public int playerMinDmg { get; set; }
        public bool alive;

        public OldPlayer(int yPos, int xPos) : base(yPos, xPos) 
        {
            Symbol = '@';
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
        
        public void Write( int x, int y)
        {

            try
            {
                if (alive == true)
                {
                    if (x >= 0 && y >= 0) // 0-based
                    {
                        
                        Console.SetCursorPosition(x, y);
                        
                    }
                }
            }
            catch (Exception)
            {
            }

            while (true)
            {
                PrintCharToMap();
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


            }
        }

    }

}