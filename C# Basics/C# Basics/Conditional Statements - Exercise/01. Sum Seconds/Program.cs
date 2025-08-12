using System;

class hello
{
    static void Main()
    {

        int time1 = int.Parse(Console.ReadLine());
        int time2 = int.Parse(Console.ReadLine());
        int time3 = int.Parse(Console.ReadLine());


        int totalTime = (time1 + time2 + time3);
        int totalMinutes = (totalTime / 60);
        int totalSeconds = (totalTime % 60);

        if (totalSeconds < 10)
        {
            Console.WriteLine($"{totalMinutes}:0{totalSeconds}");

        }

        else
        {
            Console.WriteLine($"{totalMinutes}:{totalSeconds}");
        }



    }
}



