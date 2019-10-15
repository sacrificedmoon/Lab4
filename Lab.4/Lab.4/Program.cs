using System;

namespace Lab._4
{
    //Sofia Lindgren och Robin Nurmisto
    class Program
    {
        static void map()
        {

        }
        static void Main(string[] args)
        {
            var createMap = new DungeonMap();
            createMap.PrintInfo();
            createMap.DungeonObjects();
            createMap.printMap();
            createMap.CallPlayer();
            

            
            
            Console.ReadKey(true);
        }
    }

}
