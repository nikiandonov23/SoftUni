using System;

class hello
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        bool braker = false;

        for (int i = 1; i <= n; i++)
        {
            
            for (int k = 1; k <= i; k++)
            {
                counter++;
                Console.Write(counter+" ");
                if (counter >= n)
                {
                    break;
                    braker = true;
                }
               
            }
            
            Console.WriteLine();
            if (counter >= n)
            { break; }
        }
        
    }
}