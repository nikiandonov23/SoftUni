using System;

namespace demooooooooo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)                     //vurti intervala mejdu 100000 i   3 0 0   0 0 0
            {
                string chislo = i.ToString();

                char digit1 = chislo[0];
                char digit2 = chislo[1];
                char digit3 = chislo[2];
                char digit4 = chislo[3];
                char digit5 = chislo[4];
                char digit6 = chislo[5];

                string digit11 = digit1.ToString();
                string digit22 = digit2.ToString();
                string digit33 = digit3.ToString();
                string digit44 = digit4.ToString();
                string digit55 = digit5.ToString();
                string digit66 = digit6.ToString();

                int n1 = int.Parse(digit11);
                int n2 = int.Parse(digit22);
                int n3 = int.Parse(digit33);
                int n4 = int.Parse(digit44);
                int n5 = int.Parse(digit55);
                int n6 = int.Parse(digit66);

                if (n1 + n3 + n5 == n2 + n4 + n6)
                {
                    Console.Write(i+" ");
                }



















            }

        }
    }
}
