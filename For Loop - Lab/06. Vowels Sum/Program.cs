using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();                 // softuni
            int textLenght = text.Length;                     // 7
            int textNumbers = 0;
           





            for (int i = 0; i < textLenght; i++)

            {
                char symbol = text[i];
                switch (symbol)
                {
                    case 'a':
                        textNumbers += 1;
                        break;
                    case 'e':
                        textNumbers += 2;
                        break;

                    case 'i':
                        textNumbers += 3;
                        break;

                    case 'o':
                        textNumbers += 4;
                        break;

                    case 'u':
                        textNumbers += 5;

                        break;
                }
                
            }
           
            Console.WriteLine(textNumbers);

        }
    }
}
