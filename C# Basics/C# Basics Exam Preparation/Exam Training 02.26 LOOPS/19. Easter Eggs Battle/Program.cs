using System;

namespace _19._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());
            int first = firstPlayerEggs;
            int second = secondPlayerEggs;


            for (int i = 0; i < 30; i++)
            {
                if (first<=0)
                { 
                    Console.WriteLine($"Player one is out of eggs. Player two has {second} eggs left.");
                    break;
                }
                if (second<=0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {first} eggs left.");
                    break;
                }

                
                string winner = Console.ReadLine();
                switch (winner)
                {
                    case "one":
                        
                        second -= 1;
                        break;
                    case "two":
                        first -= 1;
                       
                        break;
                   

                }
                if (firstPlayerEggs <= 0)
                { Console.WriteLine($"Player one is out of eggs. Player two has {second} eggs left."); }
                if (secondPlayerEggs <= 0)
                { Console.WriteLine($"Player two is out of eggs. Player one has {first} eggs left."); }
                if (winner == "End")
                {
                    Console.WriteLine($"Player one has {first} eggs left.");
                    Console.WriteLine($"Player two has {second} eggs left.");
                    break;
                }
            }
        }
    }
}
