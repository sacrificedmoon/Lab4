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
            foreach (var tile in roomObjectList)
            {
                Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                Console.Write(tile.Symbol);
            }
            //while (true)
            //{
            //    player.MovePlayer();
            //}

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

