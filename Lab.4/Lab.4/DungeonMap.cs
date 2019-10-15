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
        Monster monster = new Monster(5, 5, false);



        public char[,] dungeonmap = new char[,]
        {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'R', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', 'r', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', 'b', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '!', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', 'B', '#', '#', '#', '#', '#', '#', '#', '#', '#', '!', '#', '!', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '!', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', 'M', '.', 'M', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'E'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}

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
                    else if (dungeonmap[y, x] == 'M')
                    {
                        roomObjectList.Add(new Monster(y, x, false));
                    }

                    else if (dungeonmap[y, x] == 'b')
                    {
                        roomObjectList.Add(new BlueKey(y, x, false));
                    }

                    else if (dungeonmap[y, x] == 'r')
                    {
                        roomObjectList.Add(new RedKey(y, x, false));
                    }

                    else if (dungeonmap[y, x] == 'B')
                    {
                        roomObjectList.Add(new BlueDoor(y, x, false));
                    }
                    else if (dungeonmap[y, x] == 'R')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        roomObjectList.Add(new RedDoor(y, x, false));
                        Console.ResetColor();
                    }
                    else if (dungeonmap[y, x] == '#')
                    {
                        if (x <= 40 & y <= 0 | x <= 40 & y == 21 | x == 0 & y <= 21 | x == 40 & y <= 21)
                        {
                            roomObjectList.Add(new Wall(y, x, true));
                        }
                        roomObjectList.Add(new Wall(y, x, false));
                    }
                    else if (dungeonmap[y, x] == '.')
                    {
                        roomObjectList.Add(new Floor(y, x, false));
                    }
                    else if (dungeonmap[y,x] == '@')
                    {
                        roomObjectList.Add(new Player(y, x, true));
                    }
                    else if (dungeonmap[y,x] == '!')
                    {
                        roomObjectList.Add(new ItsATrap(y, x, false));
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
                    
                    switch(tile.Symbol)
                    {
                        case 'R':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                            Console.Write(tile.Symbol);
                            Console.ResetColor();
                            break;
                        case 'r':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                            Console.Write(tile.Symbol);
                            Console.ResetColor();
                            break;
                        case 'B':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                            Console.Write(tile.Symbol);
                            Console.ResetColor();
                            break;
                        case 'b':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                            Console.Write(tile.Symbol);
                            Console.ResetColor();
                            break;
                        case '!':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                            Console.Write(tile.Symbol);
                            Console.ResetColor();
                            break;
                        case 'M':
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(tile.Ypos, tile.Xpos);
                            Console.Write(tile.Symbol);
                            Console.ResetColor();
                            break;
                    }
                }
               
            }
        }

        //public void SetColor()
        //{
        //    if (tile is RedKey)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.SetCursorPosition(tile.Ypos, tile.Xpos);
        //        Console.Write(tile.Symbol);
        //        Console.ResetColor();
        //    }
        //    else if (tile is RedKey)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.SetCursorPosition(tile.Ypos, tile.Xpos);
        //        Console.Write(tile.Symbol);
        //        Console.ResetColor();
        //    }
        //    else if (tile is BlueDoor)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.SetCursorPosition(tile.Ypos, tile.Xpos);
        //        Console.Write(tile.Symbol);
        //        Console.ResetColor();
        //    }
        //    else if (tile is BlueKey)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.SetCursorPosition(tile.Ypos, tile.Xpos);
        //        Console.Write(tile.Symbol);
        //        Console.ResetColor();
        //    }
        //    else if (tile is ItsATrap)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //        Console.SetCursorPosition(tile.Ypos, tile.Xpos);
        //        Console.Write(tile.Symbol);
        //        Console.ResetColor();
        //    }
        //    else if (tile is Monster)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //        Console.SetCursorPosition(tile.Ypos, tile.Xpos);
        //        Console.Write(tile.Symbol);
        //        Console.ResetColor();
        //    }
        //}
        public void MovePlayer()
        {

            Player.y = player.Ypos;
            Player.x = player.Xpos;

            Input();
            var newPlayerYPos = player.Ypos;
            var newPlayerXPos = player.Xpos;

            Player.y = newPlayerYPos;
            Player.x = newPlayerXPos;

            Player.numberOfMoves++;
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Score: " + Player.numberOfMoves);
            
            
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

