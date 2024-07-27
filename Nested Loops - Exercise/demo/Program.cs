using System;

class hello
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        for (int i = n1; i <= n2; i++)
        {
            string currentNumber = i.ToString();

            int oddNumbers = 0;
            int evenNumbers = 0;

            for (int j = 0; j < currentNumber.Length; j++)
            {
                int digit = currentNumber[j];

                if (j % 2 == 0)
                {
                    evenNumbers += digit;
                }
                if (j % 2 != 0)
                {
                    oddNumbers += digit;
                }
            }
            if (evenNumbers == oddNumbers)
            {
                Console.Write(i + " ");
            }
        }

    }
}