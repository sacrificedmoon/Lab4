using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public abstract class Tiles
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }

        public char Symbol { get; set; }

        protected Tiles(int xposition, int yposition)
        {
            Xpos = xposition;
            Ypos = yposition;
        }

        public virtual void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-");
            Console.ResetColor();
        }
    }
}
 