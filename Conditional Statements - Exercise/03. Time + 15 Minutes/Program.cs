using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {


            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());



            int timeSumMinutes = hours * 60 + minutes + 15;

            int timeHours = timeSumMinutes / 60;
            int timeMinutes = timeSumMinutes % 60;

            if ((timeMinutes < 10) && (timeHours < 24))
            {
                Console.WriteLine($"{timeHours}:0{timeMinutes}");
            }

            else if ((timeMinutes < 10) && (timeHours >= 24))
            {
                Console.WriteLine($"0:0{timeMinutes}");
            }

            else if ((minutes>=59)&&(hours>=23))

                Console.WriteLine($"0:14");



            else
            {

                Console.WriteLine($"{timeHours}:{timeMinutes}");
            }





















        }
    }
}