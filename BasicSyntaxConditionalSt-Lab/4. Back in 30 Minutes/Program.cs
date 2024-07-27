using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = minutes + hours * 60;
            int finalMinutes = totalMinutes + 30;

            int showHours = finalMinutes / 60;
            int showMinutes = finalMinutes % 60;


            if (showMinutes>59)
            {
                showHours += 1;
                showMinutes -= 60;
            }
            if (showHours>23)
            {
                showHours -= 24;
                

            }
            if (showMinutes<10)
            {
                Console.WriteLine($"{Math.Abs(showHours)}:0{Math.Abs(showMinutes)}");
            }
            else 
            {
                Console.WriteLine($"{Math.Abs(showHours)}:{showMinutes}");
            }
            

        }
    }
}
