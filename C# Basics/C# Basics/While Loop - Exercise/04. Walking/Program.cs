using System;

class hello
{
    static void Main()
    {
        string input = Console.ReadLine();

        int targetSteps = 10000;
        int walkedSteps = 0;

        while (input!="Going home")
        {
            int inputNumber = int.Parse(input);
            walkedSteps += inputNumber;


            if (walkedSteps >= targetSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{walkedSteps - targetSteps} steps over the goal!");
                break;
            }

            input = Console.ReadLine();

        }
        if (input == "Going home")
        {
            input = Console.ReadLine();
            int inputAsNumber2 = int.Parse(input);
            walkedSteps += inputAsNumber2;
            if (walkedSteps < targetSteps)
            {
                Console.WriteLine($"{targetSteps-walkedSteps} more steps to reach goal.");
                
            }
            if (walkedSteps > targetSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{walkedSteps - targetSteps} steps over the goal!");
            }
            
        }


    }
}