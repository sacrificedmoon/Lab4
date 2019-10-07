using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    class Door : Tiles
    {
        public Door()
        {
            ImageCharacter = Constants.DoorImage;
            this.Color = Constants.DoorColor;
        }
    }
}
