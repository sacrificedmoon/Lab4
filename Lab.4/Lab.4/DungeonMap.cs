using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    class DungeonMap
    {
       public enum tiles { wall, door, monster, player, key};

        public DungeonMap()
        {

            string[,] dungeonmap = new string[10, 20];


            //try
            //{
            //    for (int i = 0; i < 21; i++)
            //    {
                    
            //        Console.SetCursorPosition(i, 0);
            //        Console.Write("#");
                    
            //        if(i == 20)
            //        {
            //            for (int j = 0; j < 10; j++)
            //            {
            //                Console.SetCursorPosition(0, j);
            //                Console.Write("#");
            //                Console.SetCursorPosition(20, j);
            //                Console.Write("#");
            //            }

            //            if(i == 20)
            //            {
            //                for (int k = 0; k <= 20; k++)
            //                {
            //                    Console.SetCursorPosition(k, 10);
            //                    Console.Write("#");
            //                    if (k > 0 && k < 19)
            //                    {
            //                        for (int l = 0; l <= k; l++)
            //                        {
            //                            Console.SetCursorPosition((1+l), 1);
            //                            Console.Write("O");
            //                        }
            //                    }
            //                }
            //            }
            //        }
                    
                    
            //    }
            //}
            //catch (Exception)
            //{
            //}

        }

            
        
    }
}

