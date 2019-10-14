using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    class Player : Tiles
    {
        public char PlayerIcon { get; set; }
        public static int numberOfMoves = 0;
        public static int x = 1;
        public static int y = 1;
        public List<Key> playerInventoryKeys = new List<Key>();
        public static bool HasKey { get; set; } = false;

        public Player(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            PlayerIcon = '@';            
        }

        public void MovePlayer()
        {
            Ypos = y;
            Xpos = x;
            var PreviousPlayerYPos = Ypos;
            var PreviousPlayerXPos = Xpos;
           
            var currentPlayerYPos = Ypos;
            var currentPlayerXPos = Xpos;

            Input();
            var newPlayerYPos = Ypos;
            var newPlayerXPos = Xpos;

            currentPlayerYPos = newPlayerYPos;
            currentPlayerXPos = newPlayerXPos;
            //y = newPlayerYPos;
            //x = newPlayerXPos;
            //Console.SetCursorPosition(y, x);
            //Console.WriteLine("@");
            numberOfMoves++;
            
            
        }

        public static int Input()
        {
            try
            {
                if (true)
                {
                    if (y >= 0 && x >= 0) // 0-based
                    {

                        Console.SetCursorPosition(y, x);
                        Console.WriteLine('@');
                        Console.SetCursorPosition(y, x);
                    }
                }
            }
            catch (Exception)
            {
            }
            var command = Console.ReadKey().Key;

            switch (command)
            {
                case ConsoleKey.DownArrow:
                    x++;
                    return x;
                case ConsoleKey.UpArrow:
                    if (x > 0)
                    {
                        x--; 
                    }
                    return x;
                case ConsoleKey.LeftArrow:
                    if (y > 0)
                    {
                        y--;
                    }
                    return y;
                case ConsoleKey.RightArrow:
                    y++;
                    return y;
                default:
                    return 0;
 
            }
        }
    }
}
