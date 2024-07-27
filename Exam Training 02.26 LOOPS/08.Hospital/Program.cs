using System;

namespace _08.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int UnTreatedPatients = 0;
            int TreatedPatients = 0;
            int TotalPatients = 0;
            int DailyPatients = 0;


            for (int i = 1; i <= days; i++)
            {
                DailyPatients += int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (UnTreatedPatients > doctors))
                { doctors += 1; }
                if (DailyPatients > doctors)
                {
                    TreatedPatients += doctors;
                    UnTreatedPatients += DailyPatients - doctors;
                }
                if (DailyPatients < doctors)
                {
                    TreatedPatients += DailyPatients;
                    UnTreatedPatients = 0;
                }
                else
                { TreatedPatients += DailyPatients; }
                

            }



            Console.WriteLine($"treatd {TreatedPatients}");
            Console.WriteLine($"{UnTreatedPatients}");
            Console.WriteLine($"doctors {doctors}");

        }
    }
}
