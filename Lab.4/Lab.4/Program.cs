using System;

namespace Lab4
{
    //Sofia Lindgren och Robin Nurmisto
    class Program
    {
        static void Main(string[] args)
        {
            //testkod för att kontrollera player och monster
            Player player = new Player();
            player.playerName = Console.ReadLine();
            Console.WriteLine(player.PlayerInfo());

            Monster newMonster = new Monster();
            Console.WriteLine(newMonster.monsterhealth + " " + newMonster.monsterMinDmg);

            Console.ReadLine();
            //Slut på testkod

        }
    }
}
