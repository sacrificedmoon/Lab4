using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Floor : Tiles
    {
       public Floor(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = '.';
        }
      
        
    }
}
