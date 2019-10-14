using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class DungeonMap
    {
        public static List<Tiles> roomObjectList = new List<Tiles> { };
        Player player = new Player(1,1, true);



        public  char  [,] dungeonmap =  new  char[,]
        {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', 'K', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', 'D', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}

        };



        public void DungeonObjects()
        {
            for (int y = 0; y < dungeonmap.GetLength(0); y++)
            {
                for (int x = 0; x < dungeonmap.GetLength(1); x++)
                {
                    int temp = dungeonmap.GetLength(1);
                    if (dungeonmap[y, x] == 'E')
                    {
                        roomObjectList.Add(new Exit(y, x, false));
                    }

                    else if (dungeonmap[y, x] == 'K')
                    {
                        roomObjectList.Add(new Key(y, x, false));
                    }

                    else if (dungeonmap[y, x] == 'D')
                    {
                        roomObjectList.Add(new Door(y, x, false));
                    }
                    else if (dungeonmap[y, x] == '#')
                    {
                        roomObjectList.Add(new Wall(y, x, true));
                    }
                    else if (dungeonmap[y, x] == '.')
                    {
                        roomObjectList.Add(new Floor(y, x, false));
                    }
                    else if (dungeonmap[y,x] == '@')
                    {
                        roomObjectList.Add(new Player(y, x, true));
                    }
                }
            }
        }

        static public Tiles GetTileObject(int x, int y)
        {
            foreach (Tiles tile in roomObjectList)
            {
                if (tile.Xpos == x && tile.Ypos == y)
                {
                    return tile;
                }
            }
            return null;
        }

        public void printMap()
        {
            
            foreach (var tile in roomObjectList)
            {
                if (player.Ypos == tile.Ypos + 1 | player.Ypos == tile.Ypos + 2 | player.Ypos == tile.Ypos - 1 | player.Ypos == tile.Ypos - 2 | player.Ypos == tile.Ypos && player.Xpos == tile.Xpos + 1 | player.Xpos == tile.Xpos + 2 | player.Xpos == tile.Xpos - 1 | player.Xpos == tile.Xpos - 2 | player.Xpos == tile.Xpos)
                {
                    tile.IsExplored = true;                    
                }

                if (tile.IsExplored == true)
                {
                    Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                    Console.Write(tile.Symbol);                    
                }
                else if(tile is Wall)
                {
                    Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                    Console.Write(tile.Symbol);
                }
            }
        }
        public void MovePlayer()
        {
            
            //var PreviousPlayerYPos = y;
            //var PreviousPlayerXPos = x;

            Player.y = player.Ypos;
            Player.x = player.Xpos;

            Input();
            var newPlayerYPos = player.Ypos;
            var newPlayerXPos = player.Xpos;

            Player.y = newPlayerYPos;
            Player.x = newPlayerXPos;

            Player.numberOfMoves++;
            
            
        }
        public int Input()
        {
            try
            {
                if (true)
                {
                    if (player.Ypos >= 0 && player.Xpos >= 0) // 0-based
                    {

                        Console.SetCursorPosition(player.Ypos, player.Xpos);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(player.PlayerIcon);
                        Console.ResetColor();
                        Console.SetCursorPosition(player.Ypos, player.Xpos);

                    }
                }
            }
            catch (Exception)
            {
            }
            var command = Console.ReadKey().Key;

            switch (command)
            {
                case ConsoleKey.DownArrow:
                    if (GetTileObject(player.Xpos +1, player.Ypos).CanPass() == true)
                    {
                        player.Xpos++;
                    }
                    if (GetTileObject(player.Xpos, player.Ypos) is IInteractable)
                        (GetTileObject(player.Xpos, player.Ypos) as IInteractable).PlayerInteract();
                    return player.Xpos;

                case ConsoleKey.UpArrow:
                    if (GetTileObject(player.Xpos - 1, player.Ypos).CanPass() == true)
                    {
                        player.Xpos--;
                    }
                    if (GetTileObject(player.Xpos, player.Ypos) is IInteractable)
                        (GetTileObject(player.Xpos, player.Ypos) as IInteractable).PlayerInteract();
                    
                    return player.Xpos;

                case ConsoleKey.LeftArrow:
                    if (GetTileObject(player.Xpos, player.Ypos - 1).CanPass() == true)
                    {
                        player.Ypos--;
                    }
                    if (GetTileObject(player.Xpos, player.Ypos) is IInteractable)
                        (GetTileObject(player.Xpos, player.Ypos) as IInteractable).PlayerInteract();

                    return player.Ypos;

                case ConsoleKey.RightArrow:
                    if (GetTileObject(player.Xpos, player.Ypos + 1).CanPass() == true)
                    {
                        player.Ypos++;
                    }
                    if (GetTileObject(player.Xpos, player.Ypos) is IInteractable)
                        (GetTileObject(player.Xpos, player.Ypos) as IInteractable).PlayerInteract();
                   
                    return player.Ypos;
                default:
                    return 0;

            }
        }



        public void CallPlayer()
        {
            while (true)
            {
                MovePlayer();
                printMap();
            }
            
        }
       
    }
}

