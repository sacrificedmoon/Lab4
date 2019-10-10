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

        //public void Write(char toWrite = playerIcon, int x = 0, int y = 0)
        //{

        //    try
        //    {
        //        if (alive == true)
        //        {
        //            if (x >= 0 && y >= 0) // 0-based
        //            {
        //                //sätt den gammla positionen till blank, eller kartan 
        //                Console.SetCursorPosition(x, y);
        //                Console.Write(toWrite);

        //            }
        //        }



        //    }
        //    catch (Exception)
        //    {
        //    }

        //    while (true)
        //    {
        //        var command = Console.ReadKey().Key;

        //        switch (command)
        //        {
        //            case ConsoleKey.DownArrow:
        //                y++;
        //                break;
        //            case ConsoleKey.UpArrow:
        //                if (y > 0)
        //                {
        //                    y--;
        //                }
        //                break;
        //            case ConsoleKey.LeftArrow:
        //                if (x > 0)
        //                {
        //                    x--;
        //                }
        //                break;
        //            case ConsoleKey.RightArrow:
        //                x++;
        //                break;
        //        }
        //        Write(toWrite, x, y);
        //    }
        //}

    }

}