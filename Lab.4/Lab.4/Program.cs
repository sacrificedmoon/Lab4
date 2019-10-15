using System;

namespace Lab._4
{
    //Sofia Lindgren och Robin Nurmisto
    //:::::::Highscore:::::::
    //       Pontus 279
    //       Simon 399
    //       Anders 1332
    //:::::::::::::::::::::::
    class Program
    {
        static void Main(string[] args)
        {
            var createMap = new GameEngine();
            createMap.PrintInfo();
            createMap.CreateDungeonObjects();
            createMap.PrintMap();
            createMap.StartGameLoop();
            
            

            
            
            Console.ReadKey(true);
        }
    }

}
