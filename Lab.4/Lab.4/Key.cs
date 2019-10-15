﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Key : Tiles, IInteractable
    {
        public Key(int yPos, int xPos, bool explored) : base(yPos, xPos, explored)
        {
            Symbol = 'K';
        }
       
        public void PlayerInteract()
        {
            Console.SetCursorPosition(0, 11);
            Player.HasKey = true;
            DungeonMap.roomObjectList.Remove(this);
            DungeonMap.roomObjectList.Add(new Floor(Xpos, Ypos, true));
            Console.SetCursorPosition(0,13);
            Console.WriteLine("You pick up a key.");
            Console.ReadKey(true);
            Console.Clear();
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("K");
        }
    }
}
