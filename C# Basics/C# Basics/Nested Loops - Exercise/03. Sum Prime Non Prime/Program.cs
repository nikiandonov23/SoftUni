using System;

class hello
{
    static void Main()
    {
        string input = Console.ReadLine();

        int primeSum = 0;
        int nonPrimeSum = 0;


        while (input != "stop")
        {

            int inputN1 = int.Parse(input);


            if (inputN1 < 0)
            { Console.WriteLine("Number is negative.");
                inputN1 = 0;
            }
            bool isPrime = true;
            for (int i = 2; i < inputN1; i++)
            {
                if (inputN1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primeSum += inputN1;
            }
            else
            {
                nonPrimeSum += inputN1;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
    }


}
