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
            //testkod för att kontrollera player och monster
            //Player player = new Player(1,1);
            //player.playerName = Console.ReadLine();
            //Console.WriteLine(player.PlayerInfo());

            //Monster newMonster = new Monster();
            //Console.WriteLine(newMonster.monsterhealth + " " + newMonster.monsterMinDmg);

            //Console.ReadLine();
            //Slut på testkod
            var createMap = new DungeonMap();
            createMap.DungeonObjects();
            createMap.printMap();
            
            Console.ReadKey(true);
        }
    }

}
