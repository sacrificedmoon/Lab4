using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Door : Tiles
    {
        public Door(int xPos, int yPos) : base(xPos, yPos) { }
            public override void PrintCharToMap()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("D");
                Console.ResetColor();
            } 
    }
        
            
        
    
}
