using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    class DungeonMap
    {
        public static List<Tiles> roomObjectList = new List<Tiles> { };
        Player player = new Player(8, 1);



        string[,] dungeonmap = new string[,]
        {
                { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "#"},
                { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "E", "#", "#", "#"}

        };



        public void DungeonObjects()
        {
            for (int y = 0; y < dungeonmap.GetLength(0); y++)
            {
                for (int x = 0; x < dungeonmap.GetLength(1); x++)
                {
                    int temp = dungeonmap.GetLength(1);
                    if (dungeonmap[y, x] == "E")
                    {
                        roomObjectList.Add(new Exit(x, y));
                        continue;
                    }
                    
                    else if (dungeonmap[y, x] == "K")
                    {
                        roomObjectList.Add(new Key(x, y));
                        continue;
                    }
                    
                    else if (dungeonmap[y, x] == "D")
                    {
                        roomObjectList.Add(new Door(x, y));
                        continue;
                    }
                    else if (dungeonmap[y, x] == "#")
                    {
                        roomObjectList.Add(new Wall(x, y));
                        continue;
                    }
                    else if (dungeonmap[y, x] == ".")
                    {
                        roomObjectList.Add(new Floor(x, y));
                        continue;
                    }
                }
            }
        }
        

    }
}

