using System;

namespace _05.Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Double numbersUnder200 = 0;
            Double numbersUnder399 = 0;
            Double numbersUnder599 = 0;
            Double numbersUnder799 = 0;
            Double numbersBiggerThan800 = 0;

            Double procentnumbersUnder200 = 0;
            Double procentnumbersUnder399 = 0;
            Double procentnumbersUnder599 = 0;
            Double procentnumbersUnder799 = 0;
            Double procentnumbersBiggerThan800 = 0;






            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                 numbersUnder200+=1;
                procentnumbersUnder200 = numbersUnder200 / n * 100;
                if ((number >= 200) && (number <= 399))
                    numbersUnder399 += 1;
                procentnumbersUnder399 = numbersUnder399 / n * 100;

                if ((number >= 400) && (number <= 599))
                    numbersUnder599 += 1;
                procentnumbersUnder599 = numbersUnder599 / n * 100;

                if ((number >= 600) && (number <= 799))
                    numbersUnder799 += 1;
                procentnumbersUnder799 = numbersUnder799 / n * 100;

                if (number >= 800)
                    numbersBiggerThan800 += 1;
                procentnumbersBiggerThan800 = numbersBiggerThan800 / n * 100;
            }
            Console.WriteLine($"{procentnumbersUnder200:f2}%");
            Console.WriteLine($"{procentnumbersUnder399:f2}%");
            Console.WriteLine($"{procentnumbersUnder599:f2}%");
            Console.WriteLine($"{procentnumbersUnder799:f2}%");
            Console.WriteLine($"{procentnumbersBiggerThan800:f2}%");





        }
    }
}
