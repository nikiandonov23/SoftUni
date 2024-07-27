using System;

namespace demoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();


            for (char i = number1[0]; i <= number2[0]; i++)
            {
                for (char j = number1[1]; j <= number2[1]; j++)
                {
                    for (char k = number1[2]; k <=number2[2]; k++)
                    {
                        for (char p = number1[3]; p <= number2[3]; p++)
                        {
                            if ((i%2!=0)&&(j%2!=0)&&(k%2!=0)&&(p%2!=0))
                            {
                                Console.Write($"{i}{j}{k}{p} ");
                            }
                        }
                    }
                }
            }
           


        }
    }
}
