using System;

namespace demooooo
{
    class Program
    {
        static void Main(string[] args)
        {



            int lostGames = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashed = 0;
            int mouseTrashed = 0;
            int keyboardTrashed = 0;
            int displayTrashed = 0;


            for (int i = 1; i <= lostGames; i += 1)
            {
                if (i % 2 == 0)
                {
                    headsetTrashed += 1;
                }
                if (i % 3 == 0)
                {
                    mouseTrashed += 1;
                }
                if ((i % 2 == 0) && (i % 3 == 0))
                {
                    
                    keyboardTrashed += 1;

                }
                displayTrashed = keyboardTrashed / 2;



            }
            double totalExpences = headsetPrice * headsetTrashed + mousePrice * mouseTrashed + keyboardPrice * keyboardTrashed+displayPrice*displayTrashed;
            
            Console.WriteLine($"Rage expenses: {totalExpences:f2} lv.");
        }
    }
}
