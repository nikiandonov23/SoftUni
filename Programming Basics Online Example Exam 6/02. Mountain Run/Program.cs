using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());       //na vseki 50 metra , kum vremeto se dobavqr 30sek

            double extraSeconds = Math.Floor(distanceInMeters / 50) * 30;

            double finalTime = distanceInMeters * timeForMeter + extraSeconds;

            if (finalTime<record)
            {
                Console.WriteLine($" Yes! The new record is {finalTime:f2} seconds.");
            }
            if (finalTime>=record)
            {
                Console.WriteLine($"No! He was {finalTime-record:f2} seconds slower.");
            }
        }
    }
}
