using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    class Tiles
    {
        public string Name { get; set; }
        public string ImageCharacter { get; set; }
        public ConsoleColor Color { get; set; }

        public Tiles()
        {
            ImageCharacter = Constants.TileImage;
            Color = Constants.TileColor;
        }
    }
}
