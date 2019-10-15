using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class GameEngine
    {
        public static List<Tiles> roomObjectList = new List<Tiles> { };
        Player player = new Player(1,1, true);
        Monster monster = new Monster(5, 5, false);

        public char[,] dungeonmap = new char[,]
        {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'R', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '!', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', 'r', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '.', 'M', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', 'b', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '#', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '#', '#', '#', '#', '.', '#', '#', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '!', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', 'B', '#', '#', '#', '#', '#', '#', '#', '#', '#', '!', '#', '!', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                { '#', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '!', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', '#', '#', '.', '#', '.', 'M', '.', 'M', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', '.', '#', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', 'M', '#', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'M', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', '.', '#', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', '.', '#', '.', '#', '.', '.', '.', '.', '.', '.', '#', '#', '#', '.', '.', '.', '.', '#', '#', '#', '#', '#', '#', 'M', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '!', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#', '.', '.', '.', '.', 'M', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '#', '#', '#', '#', '#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#', '#', '#', '#', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#', 'E', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'M', '#'},
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}

        };
        public void CreateDungeonObjects() 
        {
            for (int y = 0; y < dungeonmap.GetLength(0); y++)
            {
                for (int x = 0; x < dungeonmap.GetLength(1); x++)
                {
                    switch (dungeonmap[y, x])
                    {
                        case 'E':
                            roomObjectList.Add(new Exit(y, x, false));
                            break;
                        case 'M':
                            roomObjectList.Add(new Monster(y, x, false));
                            break;
                        case 'b':
                            roomObjectList.Add(new BlueKey(y, x, false));
                            break;
                        case 'r':
                            roomObjectList.Add(new RedKey(y, x, false));
                            break;
                        case 'B':
                            roomObjectList.Add(new BlueDoor(y, x, false));
                            break;
                        case 'R':
                            roomObjectList.Add(new RedDoor(y, x, false));
                            break;
                        case '#':
                            if (x <= 40 & y <= 0 | x <= 40 & y == 21 | x == 0 & y <= 21 | x == 40 & y <= 21)
                            {
                                roomObjectList.Add(new Wall(y, x, true));
                            }
                            roomObjectList.Add(new Wall(y, x, false)); break;
                        case '.':
                            roomObjectList.Add(new Floor(y, x, false));
                            break;
                        case '@':
                            roomObjectList.Add(new Player(y, x, true));
                            break;
                        case '!':
                            roomObjectList.Add(new ItsATrap(y, x, false));
                            break;
                        default:
                            break;
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

        public void PrintMap() 
        {
            foreach (var tile in roomObjectList)
            {
                //kanske ge ett namn på nedanstående uttryck
                //bool VadUttrycketGör()
                //{
                //    return player.Ypos == tile.Ypos + 1 | player.Ypos == tile.Ypos + 2 | player.Ypos == tile.Ypos - 1 | player.Ypos == tile.Ypos - 2 | player.Ypos == tile.Ypos && player.Xpos == tile.Xpos + 1 | player.Xpos == tile.Xpos + 2 | player.Xpos == tile.Xpos - 1 | player.Xpos == tile.Xpos - 2 | player.Xpos == tile.Xpos;
                //}
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
        public void MakeNextTurn() 
        {
            MovePlayerAndInteract();
            var newPlayerYPos = player.Ypos;
            var newPlayerXPos = player.Xpos;

            Player.y = newPlayerYPos;
            Player.x = newPlayerXPos;

            Player.numberOfMoves++;
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Score: " + Player.numberOfMoves); 
        }
        
        public int MovePlayerAndInteract()
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

        public void PrintInfo()
        {
            Console.SetCursorPosition(43, 3);
            Console.Write("Use the arrow keys to move");
            Console.SetCursorPosition(43, 5);
            Console.Write("r & b are keys, R & B are doors");
            Console.SetCursorPosition(43, 7);
            Console.Write("Find the Exit, an 'E' to win");

        }

        public void StartGameLoop() //MakeNextTurn, Update, StartGameloop, whats up?
        {
            while (true)
            {       
                MakeNextTurn();
                PrintMap();
                PrintInfo();
            }
        }
    }
}

