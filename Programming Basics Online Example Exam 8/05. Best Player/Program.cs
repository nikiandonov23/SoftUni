using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();

            int MaxgoalsScored = 0;
            string winner = "";

            while (nameOfPlayer != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (MaxgoalsScored < goals)
                {
                    MaxgoalsScored = goals;
                    winner = nameOfPlayer;
                }

                if (MaxgoalsScored>=10)
                {
                    break;
                }


                nameOfPlayer = Console.ReadLine();
            }
            Console.WriteLine($"{winner} is the best player!");
            if (MaxgoalsScored < 3)
            {
                Console.WriteLine($"He has scored {MaxgoalsScored} goals.");
            }
            if (MaxgoalsScored >= 3)
            {
                Console.WriteLine($"He has scored {MaxgoalsScored} goals and made a hat-trick !!!");
            }
            
        }
    }
}
