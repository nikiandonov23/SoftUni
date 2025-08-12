using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {

            string ime = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());


            


            int neobhodimovreme = projects * 3;
            Console.WriteLine($"The architect { ime} will need {neobhodimovreme} hours to complete {projects} project/s."); 

        }
    }
}
