using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTournaments = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double totalMoney = 0;
            double totalWins = 0;
            double totalLoses = 0;
            

            for (int i = 1; i <= numberTournaments; i++)         //vurti dnite 
            {

                double dailyWinnedMoney = 0;
                double dailyWinnedGamesCounter = 0;
                double dailyLoseGamesCounter = 0;
               
                while (sport != "Finish")
                {

                   

                    string winOrLose = Console.ReadLine();

                    if (winOrLose == "win")
                    {
                        dailyWinnedMoney += 20;
                        dailyWinnedGamesCounter++;

                        totalWins++;

                    }
                    if (winOrLose == "lose")
                    {
                        dailyLoseGamesCounter++;

                        totalLoses++;
                    }


                    sport = Console.ReadLine();
                    if ((dailyWinnedGamesCounter > dailyLoseGamesCounter) && (sport == "Finish"))
                    {
                        dailyWinnedMoney *= 1.10;
                        totalMoney += dailyWinnedMoney;
                        
                    }
                    if ((dailyWinnedGamesCounter < dailyLoseGamesCounter) && (sport == "Finish"))
                    {
                        totalMoney += dailyWinnedMoney;
                    }
                }                        //vurti igrite
                 dailyWinnedGamesCounter = 0;
                dailyLoseGamesCounter = 0;
                dailyWinnedMoney = 0;
                if (i<numberTournaments)
                {
                    sport = Console.ReadLine();
                }
            }
            if (totalWins>totalLoses)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney*1.20:f2}");
            }
            if (totalWins<totalLoses)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
