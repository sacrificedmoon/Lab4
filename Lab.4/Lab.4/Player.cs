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
            
            //var PreviousPlayerYPos = y;
            //var PreviousPlayerXPos = x;

            y = Ypos;
            x = Xpos;

            Input();
            var newPlayerYPos = Ypos;
            var newPlayerXPos = Xpos;

            y = newPlayerYPos;
            x = newPlayerXPos;

            numberOfMoves++;
            
            
        }

        public int Input()
        {
            try
            {
                if (true)
                {
                    if (Ypos >= 0 && Xpos >= 0) // 0-based
                    {

                        Console.SetCursorPosition(Ypos, Xpos);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(PlayerIcon);
                        Console.ResetColor();
                        Console.SetCursorPosition(Ypos, Xpos);
                        
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
                    if (Xpos < 10)
                    {
                        Xpos++;
                    }
                    
                    return Xpos;
                case ConsoleKey.UpArrow:
                    if (Xpos > 0)
                    {
                        Xpos--; 
                    }
                    return Xpos;
                case ConsoleKey.LeftArrow:
                    if (Ypos > 0)
                    {
                        Ypos--;
                    }
                    return Ypos;
                case ConsoleKey.RightArrow:
                    if (Ypos < 19)
                    {
                        Ypos++;
                    }
                    
                    return Ypos;
                default:
                    return 0;
 
            }
        }
    }
}
