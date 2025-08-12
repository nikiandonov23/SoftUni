using System;

class hello
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int finish = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int combo = 0;
        bool isFound = false;

        for (int n1 = start; n1 <= finish; n1++)
        {
            
            for (int n2 = start; n2 <= finish; n2++)
            {
                combo++;
                if (n1 + n2 == magicNumber)
                {
                    Console.WriteLine($"Combination N:{combo} ({n1} + {n2} = {magicNumber})");
                    isFound = true;
                    break;
                }
            }
            if (isFound == true)
            {
                break;
            }

        }
        if (isFound == false)
        {
            Console.WriteLine($"{combo} combinations - neither equals {magicNumber}");
        }
        


    }
}
