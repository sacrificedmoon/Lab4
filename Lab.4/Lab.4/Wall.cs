using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Wall : Tiles
    {
        public Wall(int yPos, int xPos) : base(yPos, xPos)
        {
            Symbol = '#';
        }
        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("#");
            Console.ResetColor();
        }

    }
}
