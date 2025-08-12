using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            string input = "";

            while (input!= "End")
            {
                if ((firstPlayerEggs > 0) && (secondPlayerEggs > 0))
                {
                    input = Console.ReadLine();
                }

                if (input== "one")
                {
                    secondPlayerEggs -= 1;
                }
                if (input== "two")
                {
                    firstPlayerEggs -= 1;
                }

                if (firstPlayerEggs <= 0) 
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                    break;
                }
                if (secondPlayerEggs<=0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                    break;
                }

                
            }
            if ((input== "End")&&(firstPlayerEggs > 0) && (secondPlayerEggs > 0))
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
        }
    }
}
