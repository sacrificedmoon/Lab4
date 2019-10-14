using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Door : Tiles, IInteractable
    {
        public bool isOpen { get; private set; } = false;
        public Door(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'D';
        }

        public override bool CanPass()
        {
            return isOpen;
        }
        public void PlayerInteract()
        {
            if (isOpen == false && Player.HasKey)
            {
                isOpen = true;
                Player.HasKey = false;
                Console.WriteLine("You unlock the door with your key");
            }
           
            Console.ReadKey(true);
        }
    }
        
            
        
    
}
