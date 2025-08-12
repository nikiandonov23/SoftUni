using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());             //2345
            int number2 = int.Parse(Console.ReadLine());             //6789

            for (int i = number1; i <= number2; i++)                      //2346
            {
                string chislo = i.ToString();

                char digit1 = chislo[0];
                char digit2 = chislo[1];
                char digit3 = chislo[2];
                char digit4 = chislo[3];

                string digit11 = digit1.ToString();
                string digit22 = digit2.ToString();
                string digit33 = digit3.ToString();
                string digit44 = digit4.ToString();

                int n1 = int.Parse(digit11);
                int n2 = int.Parse(digit22);
                int n3 = int.Parse(digit33);
                int n4 = int.Parse(digit44);

                if ((n1%2!=0)&&(n2%2!=0)&&(n3%2!=0)&&(n4%2!=0))
                {
                    Console.Write($"{n1}{n2}{n3}{n4} ");
                }








            }

        }
    }
}
