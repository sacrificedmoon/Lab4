using System;
using System.Threading;

namespace Lab4
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
            Player player = new Player();
            player.playerName = Console.ReadLine();
            Console.WriteLine(player.PlayerInfo());

            Console.WriteLine("asdasdasd");
            player.Write();
            


            Monster newMonster = new Monster();
            Console.WriteLine(newMonster.monsterhealth + " " + newMonster.monsterMinDmg);

            Console.ReadLine();
            //Slut på testkod



        }

    }
}
