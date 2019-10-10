using Lab._4;
using System;
using System.Threading;

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
            Console.CursorVisible = false;
            //testkod för att kontrollera player och monster
            Player player = new Player();
            player.playerName = Console.ReadLine();
            Console.WriteLine(player.PlayerInfo());

            Console.WriteLine("asdasdasd");
            Console.Clear();
            DungeonMap map1 = new DungeonMap();
            
            player.Write();
            


            Monster newMonster = new Monster();
            Console.WriteLine(newMonster.monsterhealth + " " + newMonster.monsterMinDmg);

            Console.ReadLine();
            //Slut på testkod



        }

    }
}
