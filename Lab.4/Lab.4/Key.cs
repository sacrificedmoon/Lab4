using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    class Key : Tiles
    {
        public Key(int yPos, int xPos) : base(yPos, xPos)
        {
            Symbol = 'K';
        }
        public override void PrintCharToMap()
        {
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.Write("K");
         Console.ResetColor(); 
        }
    }
}
