using System;

class hello
{
    static void Main()
    {
        string input = Console.ReadLine();
       

        while (input != "End")
        {
            string destination = input;
            Double budget = Double.Parse(Console.ReadLine());


            Double savings = 0;
            while (savings<budget)
            {
                savings += Double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Going to {destination}!");


            input = Console.ReadLine();
            if (input == "End")
            { break; }
            

        }
    }
}
