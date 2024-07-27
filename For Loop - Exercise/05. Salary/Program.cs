using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());    //broi otvoreni tabove
            int salary = int.Parse(Console.ReadLine());
            int penalty = 0;

            for (int i = 0; i < n; i++)
            {
                string nameOfWebsite = Console.ReadLine();
                if (nameOfWebsite == "Facebook")
                {
                    penalty += 150;
                }
                if (nameOfWebsite == "Instagram")
                {
                    penalty += 100;
                }
                if (nameOfWebsite == "Reddit")
                {
                    penalty += 50;
                }
               

            }
            if (salary - penalty <= 0)
            { Console.WriteLine("You have lost your salary."); }
            else
            {
                Console.WriteLine(salary-penalty);
            }
            
            
        }
    }
}
