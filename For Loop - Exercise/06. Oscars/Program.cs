using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfAcour = Console.ReadLine();                         //ime aktior
            Double pointsOfActour = Double.Parse(Console.ReadLine());   //to4ki ot akademiqta
            Double pointsFromExaminers = 0;
            int n = int.Parse(Console.ReadLine());                    //broi ocenqvashti

            
            {


                for (int i = 0; i < n; i++)
                {
                    string nameOfExaminer = Console.ReadLine();
                    int lenght = nameOfExaminer.Length;

                    Double pointsFromExaminer = Double.Parse(Console.ReadLine());
                    pointsFromExaminers += pointsFromExaminer * lenght / 2;
                    if ((pointsOfActour + pointsFromExaminers) > 1250.5)
                    {
                        Console.WriteLine($"Congratulations, {nameOfAcour } got a nominee for leading role with {(pointsOfActour + pointsFromExaminers):f1}!");
                        break;
                    }
                }

                Double TotalPoints = pointsFromExaminers + pointsOfActour;
                if (TotalPoints < 1250.5)
                {
                    Console.WriteLine($"Sorry, { nameOfAcour  } you need {(1250.5 - TotalPoints):f1} more!");
                }


            }





        }
    }
}
