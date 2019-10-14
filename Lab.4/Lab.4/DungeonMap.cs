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
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
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

        public void printMap()
        {
            Console.Clear();
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
        public void CallPlayer()
        {
            while (true)
            {
                player.MovePlayer();
                printMap();
            }
            
        }
       
    }
}

