using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            int firstNumber = int.Parse(number1);
            int SecondNumber = int.Parse(number2);


            char digit1 = number1[0];
            char digit2 = number1[1];
            char digit3 = number1[2];
            char digit4 = number1[3];

            string digit11 = digit1.ToString();
            string digit22 = digit2.ToString();
            string digit33 = digit3.ToString();
            string digit44 = digit4.ToString();

            int n1 = int.Parse(digit11);
            int n2 = int.Parse(digit22);
            int n3 = int.Parse(digit33);
            int n4 = int.Parse(digit44);

            char digit01 = number2[0];
            char digit02 = number2[1];
            char digit03 = number2[2];
            char digit04 = number2[3];

            string digit011 = digit01.ToString();
            string digit022 = digit02.ToString();
            string digit033 = digit03.ToString();
            string digit044 = digit04.ToString();

            int n01 = int.Parse(digit011);
            int n02 = int.Parse(digit022);
            int n03 = int.Parse(digit033);
            int n04 = int.Parse(digit044);

          
                for (int j = n1; j <= n01; j++)             //vurti cifrite
                {
                    for (int k = n2; k <= n02; k++)
                    {
                        for (int p = n3; p <= n03; p++)
                        {
                            for (int c = n4; c <= n04; c++)
                            {
                                if ((j%2!=0)&&(k%2!=0)&&(p%2!=0)&&(c%2!=0))
                                {
                                    Console.Write($"{j}{k}{p}{c} ");
                                }
                            }
                        }
                    }
                }
            






















        }
    }
}
