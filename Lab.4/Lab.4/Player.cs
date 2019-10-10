using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4
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

        

        public void Write(int x = 0, int y = 0)
        {
            
            try
            {
                if(alive == true)
                {
                    if (x >= 0 && y >= 0) // 0-based
                    {
                        Console.SetCursorPosition(x,y);
                        Console.Write(Constants.PlayerImage);
                        
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
                        Console.SetCursorPosition(x, y);
                        Console.Write(Constants.TileImage);
                        y++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.Write(Constants.TileImage);
                            y--;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.Write(Constants.TileImage);
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(x, y);
                        Console.Write(Constants.TileImage);
                        x++;
                        break;
                }
                Write(x, y);
            }
        }
    }

}