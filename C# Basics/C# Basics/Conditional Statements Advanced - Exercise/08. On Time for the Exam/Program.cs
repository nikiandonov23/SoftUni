using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            examMin = examMin + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;
            int difference = examMin - arrivalMin;


            if (difference < 0)
            {
                Console.WriteLine("Late");
            }
            if ((difference >= 0) && (difference <= 30))
            {
                Console.WriteLine("On time");
            }
            if (difference > 30)
            {
                Console.WriteLine("Early");
            }
            int finalMinutes = Math.Abs(difference % 60);
            int finalHOurs = Math.Abs(difference / 60);

            if (difference <= 59 && difference > 0)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
            else if (difference >= 60)
            {
                if (finalMinutes < 10)
                {
                    Console.WriteLine($"{finalHOurs}:0{finalMinutes} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{finalHOurs}:{finalMinutes} hours before the start");
                }

            }
            else if (difference < 0 && difference >= -59)
            {
                Console.WriteLine($"{Math.Abs(difference)} minutes after the start");

            }
            else if (difference <= -60)
            {
                if (finalMinutes < 10)
                {
                    Console.WriteLine($"{finalHOurs}:0{finalMinutes} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{finalHOurs}:{finalMinutes} hours after the start");
                }
            }
        }
    }
}
