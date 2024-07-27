using System;

namespace _10._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int pointsSum = 0;
            Double firstPlace = 0;

            for (int i = 0; i < n; i++)
            {
                string klasirane = Console.ReadLine();

                switch (klasirane)
                {
                    case "W":
                        pointsSum += 2000;
                        firstPlace += 1;
                        break;
                    case "F":
                        pointsSum += 1200;
                        break;
                    case "SF":
                        pointsSum += 720;
                        break;



                }
                
            }
            int totalPoints = pointsSum + startPoints;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {(totalPoints-startPoints)/n}");
            Console.WriteLine($"{firstPlace/n*100:f2}%");
        }
    }
}
