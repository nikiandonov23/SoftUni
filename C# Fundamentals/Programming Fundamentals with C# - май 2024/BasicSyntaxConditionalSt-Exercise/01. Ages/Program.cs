using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string word = "";

            if (age >= 0 && age <= 2)
            {
                word = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                word = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                word = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                word = "adult";
            }
            else if (age >= 66)
            {
                word = "elder";
            }

            Console.WriteLine(word);


        }
    }
}
