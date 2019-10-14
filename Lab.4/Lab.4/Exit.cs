using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Exit : Tiles, IInteractable
    {
        public Exit(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'E';
        }

        public void PlayerInteract()
        {

        }
    }
}
