using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            double countAllPeople = 0;
            double countMusala = 0;
            double countMonblan = 0;
            double countKilimandjaro = 0;
            double countK2 = 0;
            double countEverest = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                double peopleInGroup = double.Parse(Console.ReadLine());

                countAllPeople += peopleInGroup;

                if (peopleInGroup <= 5)
                {
                    countMusala += peopleInGroup;
                }
                if ((peopleInGroup >= 6) && (peopleInGroup <= 12))
                {
                    countMonblan += peopleInGroup;
                }
                if ((peopleInGroup >= 13) && (peopleInGroup <= 25))
                {
                    countKilimandjaro += peopleInGroup;
                }
                if ((peopleInGroup >= 26) && (peopleInGroup <= 40))
                {
                    countK2 += peopleInGroup;
                }
                if (peopleInGroup >= 41)
                {
                    countEverest += peopleInGroup;
                }


            }
            Console.WriteLine($"{countMusala / countAllPeople * 100:f2}%");
            Console.WriteLine($"{countMonblan / countAllPeople * 100:f2}%");
            Console.WriteLine($"{countKilimandjaro / countAllPeople * 100:f2}%");
            Console.WriteLine($"{countK2 / countAllPeople * 100:f2}%");
            Console.WriteLine($"{countEverest / countAllPeople * 100:f2}%");




        }
    }
}
