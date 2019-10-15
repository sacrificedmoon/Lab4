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
        public List<BlueKey> playerInventoryKeys = new List<BlueKey>();
        public static bool HasBlueKey { get; set; } = false;
        public static bool HasRedKey { get; set;} = false;

        public Player(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            PlayerIcon = '@';            
        }
    }
}
