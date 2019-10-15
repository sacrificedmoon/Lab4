using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class ItsATrap : Tiles, IInteractable
    {
        
        public ItsATrap(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = '!';
        }

        public void PlayerInteract()
        {
            Player.numberOfMoves += 1000;
        }
    }

}
