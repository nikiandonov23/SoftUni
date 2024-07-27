using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)                                     //§ W - ако е победител получава 2000 точки
                                                                            //§ F - ако е финалист получава 1200 точки
                                                                            //§ SF - ако е полуфиналист получава 720 точки
        {
            int n = int.Parse(Console.ReadLine());                          //nomer turniri v koito shte u4astva
            int startingPoints = int.Parse(Console.ReadLine());             //to4ki s koito zapo4va Grigor
            int finalPoints = startingPoints;                                  //===========>RABOTI TESTVANO E
            
            double numberWins = 0;
            
            

            for (int i = 0; i < n; i++)
            {
                string finishPlace = Console.ReadLine();
                switch (finishPlace)
                {
                    case "W":
                        finalPoints += 2000;
                        numberWins += 1;
                        break;
                    case "F":
                        finalPoints += 1200;
                        break;
                    case "SF":
                        finalPoints += 720;
                        break;
                }

            }
            int avaragePoints = (finalPoints-startingPoints)/n;
            Double procentOfWins = numberWins / n * 100;                      //=======================>RABOTI PROVERENO
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {avaragePoints}");
            Console.WriteLine($"{procentOfWins:f2}%");
        }
    }
}
