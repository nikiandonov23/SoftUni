using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Име на сериал – текст
            //2.Продължителност на епизод – цяло число в диапазона[10… 90]
            //3.Продължителност на почивката – цяло число в диапазона[10… 120]

            string nameMovie = (Console.ReadLine());
            Double movieLenght = Double.Parse(Console.ReadLine());
            Double brakeLenght = Double.Parse(Console.ReadLine());

            Double lunchTime = (brakeLenght / 8);
            Double relaxTime = (brakeLenght / 4);

            Double totalBrakeTime = (brakeLenght - (lunchTime + relaxTime));

            if (totalBrakeTime >= movieLenght)
            {
                Console.WriteLine($"You have enough time to watch {nameMovie} and left with {Math.Ceiling(totalBrakeTime - movieLenght)} minutes free time.");


            }
            else if (totalBrakeTime < movieLenght)
            {
                Console.WriteLine($"You don't have enough time to watch {nameMovie}, you need {Math.Ceiling(movieLenght - totalBrakeTime)} more minutes.");
            }
        }
    }
}