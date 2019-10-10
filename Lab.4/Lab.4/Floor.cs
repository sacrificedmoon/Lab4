using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Floor : Tiles
    {
       public Floor(int yPos, int xPos) : base(yPos, xPos)
       {
            Symbol = '.';
        }
       public override void PrintCharToMap()
       {
         Console.ForegroundColor = ConsoleColor.Gray;
         Console.Write(".");
         Console.ResetColor();
       }
        
    }
}
