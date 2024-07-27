using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());

            double points = 0;

            int RedballsNumber = 0;
            int OrangeballsNumber = 0;
            int YellowballsNumber = 0;
            int WhiteballsNumber = 0;
            int BlackballsNumber = 0;

            int devidesFromBlackBalls = 0;

            int otherColloursPicked = 0;


            for (int i = 1; i <= numberOfBalls; i++)    //vurti broi cvetove topki koito shte se vadqt
            {
                string input = Console.ReadLine();    //cvqt vuvejdane

                if (input == "red")
                {
                    points += 5;
                    RedballsNumber++;

                }
                if (input == "orange")
                {
                    points +=10;
                    OrangeballsNumber++;
                }
                if (input == "yellow")
                {
                    points +=15;
                    YellowballsNumber++;

                }
                if (input == "white")
                {
                    points +=20;
                    WhiteballsNumber++;

                }
                if (input == "black")
                {
                    points =Math.Floor(points/2);
                    BlackballsNumber++;

                    devidesFromBlackBalls++;
                }
                if ((input != "red") && (input != "orange") && (input != "yellow") && (input != "white") && (input != "black"))
                {
                    otherColloursPicked++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {RedballsNumber}");
            Console.WriteLine($"Orange balls: {OrangeballsNumber}");
            Console.WriteLine($"Yellow balls: {YellowballsNumber}");
            Console.WriteLine($"White balls: {WhiteballsNumber}");
            Console.WriteLine($"Other colors picked: {otherColloursPicked}");
            Console.WriteLine($"Divides from black balls: {devidesFromBlackBalls}");

        }
    }
}
